using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryClient.Models;

namespace InventoryClient
{
    public partial class MainForm : Form
    {
       
        private static readonly HttpClient client = new() { BaseAddress = new Uri("https://localhost:7295/") };

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadItemsAsync();
        }

        private async Task LoadItemsAsync()
        {
            btnLoad.Enabled = false;
            try
            {
                var items = await client.GetFromJsonAsync<List<Item>>("api/Items");
                dataGridView1.DataSource = items ?? new List<Item>();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Could not connect to the inventory API. Make sure it is running at {client.BaseAddress}.\n\n{ex.Message}", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load items: {ex.Message}", "Inventory error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoad.Enabled = true;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Enter a name, code, and brand.", "Missing item details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Enter a valid unit price of zero or greater.", "Invalid unit price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            btnAdd.Enabled = false;
            try
            {
                var newItem = new Item
                {
                    Name = txtName.Text.Trim(),
                    Code = txtCode.Text.Trim(),
                    Brand = txtBrand.Text.Trim(),
                    UnitPrice = unitPrice
                };

                using var response = await client.PostAsJsonAsync("api/Items", newItem);
                if (response.IsSuccessStatusCode)
                {
                    txtName.Clear();
                    txtCode.Clear();
                    txtBrand.Clear();
                    txtPrice.Clear();
                    await LoadItemsAsync();
                }
                else
                {
                    var details = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        string.IsNullOrWhiteSpace(details) ? $"The API rejected the item ({(int)response.StatusCode} {response.ReasonPhrase})." : details,
                        "Unable to add item",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Could not connect to the inventory API. Make sure it is running at {client.BaseAddress}.\n\n{ex.Message}", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to add item: {ex.Message}", "Inventory error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAdd.Enabled = true;
            }
        }

    }
}
