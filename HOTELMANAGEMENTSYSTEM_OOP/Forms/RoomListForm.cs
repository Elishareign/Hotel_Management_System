using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;


namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    public partial class RoomListForm : Form
    {
        private IRoomRepository roomRepository;
        private List<Room> allRooms; // To hold all rooms data

        public RoomListForm()
        {
            InitializeComponent();
            roomRepository = new SQLiteRoomRepository(); // Initialize repository

            // Load data into DataGridView
            LoadRoomData();

            // Handle events
            dataGridViewRooms.CellValueChanged += DataGridViewRooms_CellValueChanged;
            dataGridViewRooms.CurrentCellDirtyStateChanged += DataGridViewRooms_CurrentCellDirtyStateChanged;
            textSearch.TextChanged += textSearch_TextChanged;
        }

        private void LoadRoomData()
        {
            allRooms = roomRepository.GetAllRooms(); // Load all rooms
            DisplayRooms(allRooms); // Display all rooms initially
        }

        private void DisplayRooms(List<Room> rooms)
        {
            dataGridViewRooms.Rows.Clear();

            // Populate DataGridView
            foreach (var room in rooms)
            {
                Image roomStatusImage = null;

                // Determine which image to use based on room status
                switch (room.RoomStatus)
                {
                    case Status.Available:
                        roomStatusImage = imageList1.Images[0];
                        break;
                    case Status.Occupied:
                        roomStatusImage = imageList1.Images[1];
                        break;
                    case Status.UnderMaintenance:
                        roomStatusImage = imageList1.Images[2];
                        break;
                    default:
                        break;
                }

                dataGridViewRooms.Rows.Add(
                    false,
                    room.RoomNumber,
                    room.RoomTypeName,
                    room.FloorNumber,
                    room.Capacity,
                    room.NumberOfBeds,
                    room.PricePerNight,
                    roomStatusImage,
                    room.RoomStatus.ToString()
                );
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textSearch.Texts.ToLower();
            var filteredRooms = allRooms.Where(room =>
                room.RoomNumber.ToString().Contains(searchText) ||
                room.RoomTypeName.ToLower().Contains(searchText) ||
                room.FloorNumber.ToString().Contains(searchText) ||
                room.Capacity.ToString().Contains(searchText) ||
                room.NumberOfBeds.ToString().Contains(searchText) ||
                room.PricePerNight.ToString().Contains(searchText) ||
                (room.RoomStatus.HasValue && room.RoomStatus.ToString().ToLower().Contains(searchText))).ToList();

            DisplayRooms(filteredRooms);
        }

        private void DataGridViewRooms_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.IsCurrentCellDirty)
            {
                dataGridViewRooms.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewRooms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRooms.Columns["Select"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridViewRooms.Rows[e.RowIndex].Cells["Select"];
                bool isChecked = (bool)checkBoxCell.Value;

                MessageBox.Show($"Row {e.RowIndex} checkbox is {(isChecked ? "checked" : "unchecked")}");
            }
        }

        private void UnderMaintenance_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRooms.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    if (int.TryParse(row.Cells["RoomNumber"].Value.ToString(), out int roomNumber))
                    {
                        var room = allRooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
                        if (room != null)
                        {
                            int roomId = room.RoomID;

                            // Call the repository method to update status
                            roomRepository.UpdateRoomStatusToUnderMaintenance(roomId);

                            // Update the UI
                            row.Cells["CurrentRoomStatus"].Value = "Under Maintenance";
                        }
                        else
                        {
                            MessageBox.Show($"Room with number {roomNumber} not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid room number format.");
                    }
                }
            }

            LoadRoomData();
        }

    }
}