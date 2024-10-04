using HOTELMANAGEMENTSYSTEM_OOP.Model;
using HOTELMANAGEMENTSYSTEM_OOP.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace HOTELMANAGEMENTSYSTEM_OOP.Services
{
    public class RoomService
    {
        private readonly IRoomRepository roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
        }

        public List<Room> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }

        public List<Room> GetAvailableRooms(DateTime fromDate, DateTime toDate)
        {
            return roomRepository.GetAvailableRooms(fromDate, toDate);
        }

        public RoomDetails GetRoomDetailsById(int roomId)
        {
            return roomRepository.GetRoomDetailsById(roomId);
        }


        public bool RoomExists(int roomId)
        {
            return roomRepository.RoomExists(roomId); // Implement RoomExists method in your repository
        }

        public void UpdateRoomStatus(int roomId, Status newStatus)
        {
            RoomDetails room = roomRepository.GetRoomDetailsById(roomId);
            if (room != null)
            {
                room.RoomStatus = newStatus;
                roomRepository.UpdateRoomStatus(roomId, newStatus);

            }
        }

        public bool IsRoomAvailable(int roomId, DateTime fromDate, DateTime toDate)
        {
            RoomDetails roomDetails = roomRepository.GetRoomDetailsById(roomId);
            if (roomDetails != null)
            {
                List<Room> availableRooms = roomRepository.GetAvailableRooms(fromDate, toDate);

                return availableRooms.Any(r => r.RoomID == roomDetails.RoomID);
            }
            return false;
        }


        public List<Room> GetAvailableRoomsToEdit(DateTime fromDate, DateTime toDate, string roomTypeName, int? floorNumber)
        {
            return roomRepository.GetAvailableRoomsToEdit(fromDate, toDate, roomTypeName, floorNumber);
        }


        public List<RoomType> GetRoomTypes()
        {
            return roomRepository.GetRoomTypes();
        }

        public int GetAvailableRoomCount()
        {
            return roomRepository.GetAvailableRoomCount();
        }

    }
}