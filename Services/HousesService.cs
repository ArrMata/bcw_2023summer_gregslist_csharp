namespace bcw_2023summer_gregslist_csharp.Services
{
	public class HousesService
	{
		private readonly HousesRepository _housesRepository;

		public HousesService(HousesRepository housesRepository)
		{
			_housesRepository = housesRepository;
		}

		internal House CreateHouse(House houseData)
		{
			int houseId = _housesRepository.CreateHouse(houseData);
			House house = GetHouseById(houseId);
			return house;
		}

		internal void DeleteHouse(int houseId)
		{
			GetHouseById(houseId);
			_housesRepository.DeleteHouse(houseId);
		}

    internal House GetHouseById(int houseId)
		{
			House house = _housesRepository.GetHouseById(houseId);
			if (house == null)
			{
				throw new Exception($"There is no house with ID: {houseId}");
			}
			return house;
		}

		internal List<House> GetHouses()
		{
			List<House> houses = _housesRepository.GetHouses();
			return houses;
		}

		internal House UpdateHouse(int houseId, House houseData)
		{
			House originalHouse = GetHouseById(houseId);
			originalHouse.Sqft = houseData.Sqft ?? originalHouse.Sqft;
			originalHouse.Bedrooms = houseData.Bedrooms ?? originalHouse.Bedrooms;
			originalHouse.Bathrooms = houseData.Bathrooms ?? originalHouse.Bathrooms;
			originalHouse.ImgUrl = houseData.ImgUrl ?? originalHouse.ImgUrl;
			originalHouse.Description = houseData.Description ?? originalHouse.Description;
			originalHouse.Price = houseData.Price ?? originalHouse.Price;
			House updatedHouse = _housesRepository.UpdateHouse(originalHouse);
			return updatedHouse;
		}
	}
}