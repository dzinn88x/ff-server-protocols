using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C0F RID: 7183
	[Token(Token = "0x2001C0F")]
	public class CSSharedItemDataManager : SingletonModule<CSSharedItemDataManager>
	{
		// Token: 0x06009C73 RID: 40051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C73")]
		[Address(RVA = "0x14F1BEC", Offset = "0x14F1BEC", VA = "0x7BBBCF1BEC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C74")]
		[Address(RVA = "0x14F1D5C", Offset = "0x14F1D5C", VA = "0x7BBBCF1D5C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C75")]
		[Address(RVA = "0x14F1AF0", Offset = "0x14F1AF0", VA = "0x7BBBCF1AF0")]
		public void SetCSItemDataEndtime(uint id, string endTime)
		{
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C76")]
		[Address(RVA = "0x14F0C28", Offset = "0x14F0C28", VA = "0x7BBBCF0C28")]
		public string GetCSItemDataEndtime(uint id)
		{
			return null;
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C77")]
		[Address(RVA = "0x14F1A78", Offset = "0x14F1A78", VA = "0x7BBBCF1A78")]
		public void SetCSItemDataSubType(uint id, byte subtype)
		{
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x000290D0 File Offset: 0x000272D0
		[Token(Token = "0x6009C78")]
		[Address(RVA = "0x14F0B20", Offset = "0x14F0B20", VA = "0x7BBBCF0B20")]
		public byte GetCSItemDataSubType(uint id)
		{
			return 0;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x000290E8 File Offset: 0x000272E8
		[Token(Token = "0x6009C79")]
		[Address(RVA = "0x14F2708", Offset = "0x14F2708", VA = "0x7BBBCF2708")]
		public bool IsLoadoutPlayCard(uint InId)
		{
			return default(bool);
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x00029100 File Offset: 0x00027300
		[Token(Token = "0x6009C7A")]
		[Address(RVA = "0x14F2878", Offset = "0x14F2878", VA = "0x7BBBCF2878")]
		public uint GetCSLoadoutPlayCardIdById(uint InId)
		{
			return 0U;
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x00029118 File Offset: 0x00027318
		[Token(Token = "0x6009C7B")]
		[Address(RVA = "0x14F2914", Offset = "0x14F2914", VA = "0x7BBBCF2914")]
		public CSSharedItemDataManager.LoadoutSubType GetCSLoadoutSubTypeById(uint InId)
		{
			return CSSharedItemDataManager.LoadoutSubType.LoadoutType_NONE;
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C7C")]
		[Address(RVA = "0x14F29B0", Offset = "0x14F29B0", VA = "0x7BBBCF29B0")]
		public List<Item> GetLoadoutListByType(CSSharedItemDataManager.LoadoutSubType subType)
		{
			return null;
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x00029130 File Offset: 0x00027330
		[Token(Token = "0x6009C7D")]
		[Address(RVA = "0x14F2C94", Offset = "0x14F2C94", VA = "0x7BBBCF2C94")]
		public int GetCSLoadoutPageID(uint InId)
		{
			return 0;
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C7E")]
		[Address(RVA = "0x14F2D30", Offset = "0x14F2D30", VA = "0x7BBBCF2D30")]
		public string GetLoadoutSpriteNameById(uint InId)
		{
			return null;
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x00029148 File Offset: 0x00027348
		[Token(Token = "0x6009C7F")]
		[Address(RVA = "0x14F2DDC", Offset = "0x14F2DDC", VA = "0x7BBBCF2DDC")]
		public bool IsCSLoadoutSold(uint InId)
		{
			return default(bool);
		}

		// Token: 0x06009C80 RID: 40064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C80")]
		[Address(RVA = "0x14F2E80", Offset = "0x14F2E80", VA = "0x7BBBCF2E80")]
		public Dictionary<uint, CSSharedItemData> GetItemDict()
		{
			return null;
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C81")]
		[Address(RVA = "0x14F2E88", Offset = "0x14F2E88", VA = "0x7BBBCF2E88")]
		public CSSharedItemData FindCSSharedItemDataById(uint InId)
		{
			return null;
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C82")]
		[Address(RVA = "0x14F2F10", Offset = "0x14F2F10", VA = "0x7BBBCF2F10")]
		public string FindCSSharedItemTypeSpriteNameById(uint InId)
		{
			return null;
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C83")]
		[Address(RVA = "0x14F32BC", Offset = "0x14F32BC", VA = "0x7BBBCF32BC")]
		public List<CSSharedItemData> FindCSSharedItemListByType(int iType)
		{
			return null;
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C84")]
		[Address(RVA = "0x14F319C", Offset = "0x14F319C", VA = "0x7BBBCF319C")]
		public CSSharedItemData FindCSSharedItemDataCoverLimitcard(uint id)
		{
			return null;
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C85")]
		[Address(RVA = "0x14F3344", Offset = "0x14F3344", VA = "0x7BBBCF3344")]
		public BattleFlagConfigData FindBattleFlagConfigDataByID(uint id)
		{
			return null;
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C86")]
		[Address(RVA = "0x14F33CC", Offset = "0x14F33CC", VA = "0x7BBBCF33CC")]
		public BattleFlagConfigData FindBattleFlagConfigDataByLinkID(uint id)
		{
			return null;
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x00029160 File Offset: 0x00027360
		[Token(Token = "0x6009C87")]
		[Address(RVA = "0x14F3454", Offset = "0x14F3454", VA = "0x7BBBCF3454")]
		public static Color GetRareColor(uint rare)
		{
			return default(Color);
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C88")]
		[Address(RVA = "0x14F3538", Offset = "0x14F3538", VA = "0x7BBBCF3538")]
		public static string GetRareColorBBCode(uint rare, string name)
		{
			return null;
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x00029178 File Offset: 0x00027378
		[Token(Token = "0x6009C89")]
		[Address(RVA = "0x14F35C0", Offset = "0x14F35C0", VA = "0x7BBBCF35C0")]
		public static CSSharedItemDataManager.CollectionSubType GetCollectionSubTypeByID(uint iid)
		{
			return CSSharedItemDataManager.CollectionSubType.NOTCOLLECTION;
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C8A")]
		[Address(RVA = "0x14F3664", Offset = "0x14F3664", VA = "0x7BBBCF3664")]
		public List<CSSharedItemData> DefaultPVEWeapons()
		{
			return null;
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C8B")]
		[Address(RVA = "0x14F366C", Offset = "0x14F366C", VA = "0x7BBBCF366C")]
		public void ProcessIpTagConfig(CSGetIPTagConfigRes res)
		{
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C8C")]
		[Address(RVA = "0x14F367C", Offset = "0x14F367C", VA = "0x7BBBCF367C")]
		public IPTagConfigDesc FindIpTagDescByID(uint itemID)
		{
			return null;
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C8D")]
		[Address(RVA = "0x14F3754", Offset = "0x14F3754", VA = "0x7BBBCF3754")]
		public CSSharedItemDataManager()
		{
		}

		// Token: 0x0400A23A RID: 41530
		[Token(Token = "0x400A23A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, CSSharedItemData> m_dictIdToCSItemData;

		// Token: 0x0400A23B RID: 41531
		[Token(Token = "0x400A23B")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, string> m_dictIdToCSItemDataEndtime;

		// Token: 0x0400A23C RID: 41532
		[Token(Token = "0x400A23C")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, byte> m_dictIdToCSItemDataSubType;

		// Token: 0x0400A23D RID: 41533
		[Token(Token = "0x400A23D")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, List<CSSharedItemData>> m_dictTypeToCSItemData;

		// Token: 0x0400A23E RID: 41534
		[Token(Token = "0x400A23E")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, CSSharedLoadoutData> m_dictIdtoCSLoadoutData;

		// Token: 0x0400A23F RID: 41535
		[Token(Token = "0x400A23F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, BattleFlagConfigData> m_dictIdToBattleFlagConfigData;

		// Token: 0x0400A240 RID: 41536
		[Token(Token = "0x400A240")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, BattleFlagConfigData> m_dictLinkIdToBattleFlagConfigData;

		// Token: 0x0400A241 RID: 41537
		[Token(Token = "0x400A241")]
		[FieldOffset(Offset = "0x50")]
		private List<CSSharedItemData> m_DefaultPVEWeapons;

		// Token: 0x0400A242 RID: 41538
		[Token(Token = "0x400A242")]
		[FieldOffset(Offset = "0x58")]
		private List<IPTagConfigDesc> m_IPTagConfigDesc;

		// Token: 0x02001C10 RID: 7184
		[Token(Token = "0x2001C10")]
		public enum ItemType
		{
			// Token: 0x0400A244 RID: 41540
			[Token(Token = "0x400A244")]
			ITEMTYPENONE,
			// Token: 0x0400A245 RID: 41541
			[Token(Token = "0x400A245")]
			Avatar,
			// Token: 0x0400A246 RID: 41542
			[Token(Token = "0x400A246")]
			Clothes,
			// Token: 0x0400A247 RID: 41543
			[Token(Token = "0x400A247")]
			LimitedCard,
			// Token: 0x0400A248 RID: 41544
			[Token(Token = "0x400A248")]
			TreasureBox,
			// Token: 0x0400A249 RID: 41545
			[Token(Token = "0x400A249")]
			Props,
			// Token: 0x0400A24A RID: 41546
			[Token(Token = "0x400A24A")]
			RoomCard,
			// Token: 0x0400A24B RID: 41547
			[Token(Token = "0x400A24B")]
			Bundle,
			// Token: 0x0400A24C RID: 41548
			[Token(Token = "0x400A24C")]
			Debris,
			// Token: 0x0400A24D RID: 41549
			[Token(Token = "0x400A24D")]
			Collection,
			// Token: 0x0400A24E RID: 41550
			[Token(Token = "0x400A24E")]
			VirtualGoods,
			// Token: 0x0400A24F RID: 41551
			[Token(Token = "0x400A24F")]
			BonusCard,
			// Token: 0x0400A250 RID: 41552
			[Token(Token = "0x400A250")]
			WeaponSkin,
			// Token: 0x0400A251 RID: 41553
			[Token(Token = "0x400A251")]
			Pet,
			// Token: 0x0400A252 RID: 41554
			[Token(Token = "0x400A252")]
			BattleFlag,
			// Token: 0x0400A253 RID: 41555
			[Token(Token = "0x400A253")]
			ElitePassDebris,
			// Token: 0x0400A254 RID: 41556
			[Token(Token = "0x400A254")]
			RelationItem,
			// Token: 0x0400A255 RID: 41557
			[Token(Token = "0x400A255")]
			OptionalBundle,
			// Token: 0x0400A256 RID: 41558
			[Token(Token = "0x400A256")]
			ItemHide = 99
		}

		// Token: 0x02001C11 RID: 7185
		[Token(Token = "0x2001C11")]
		public enum CollectionSubType
		{
			// Token: 0x0400A258 RID: 41560
			[Token(Token = "0x400A258")]
			NOTCOLLECTION,
			// Token: 0x0400A259 RID: 41561
			[Token(Token = "0x400A259")]
			Banner,
			// Token: 0x0400A25A RID: 41562
			[Token(Token = "0x400A25A")]
			HeadPic,
			// Token: 0x0400A25B RID: 41563
			[Token(Token = "0x400A25B")]
			LootBox,
			// Token: 0x0400A25C RID: 41564
			[Token(Token = "0x400A25C")]
			BackPack,
			// Token: 0x0400A25D RID: 41565
			[Token(Token = "0x400A25D")]
			Parachute,
			// Token: 0x0400A25E RID: 41566
			[Token(Token = "0x400A25E")]
			Skyboard,
			// Token: 0x0400A25F RID: 41567
			[Token(Token = "0x400A25F")]
			Weapon,
			// Token: 0x0400A260 RID: 41568
			[Token(Token = "0x400A260")]
			VehicleSkin,
			// Token: 0x0400A261 RID: 41569
			[Token(Token = "0x400A261")]
			Emote,
			// Token: 0x0400A262 RID: 41570
			[Token(Token = "0x400A262")]
			Pin,
			// Token: 0x0400A263 RID: 41571
			[Token(Token = "0x400A263")]
			Flight,
			// Token: 0x0400A264 RID: 41572
			[Token(Token = "0x400A264")]
			Max
		}

		// Token: 0x02001C12 RID: 7186
		[Token(Token = "0x2001C12")]
		public enum CharacterSubType
		{
			// Token: 0x0400A266 RID: 41574
			[Token(Token = "0x400A266")]
			NONE,
			// Token: 0x0400A267 RID: 41575
			[Token(Token = "0x400A267")]
			Avatar,
			// Token: 0x0400A268 RID: 41576
			[Token(Token = "0x400A268")]
			AvatarBundle,
			// Token: 0x0400A269 RID: 41577
			[Token(Token = "0x400A269")]
			AvatarDebirs,
			// Token: 0x0400A26A RID: 41578
			[Token(Token = "0x400A26A")]
			AvatarUpgradeCard,
			// Token: 0x0400A26B RID: 41579
			[Token(Token = "0x400A26B")]
			AvatarBox
		}

		// Token: 0x02001C13 RID: 7187
		[Token(Token = "0x2001C13")]
		public enum LoadoutSubType
		{
			// Token: 0x0400A26D RID: 41581
			[Token(Token = "0x400A26D")]
			LoadoutType_NONE,
			// Token: 0x0400A26E RID: 41582
			[Token(Token = "0x400A26E")]
			LoadoutType_OLD,
			// Token: 0x0400A26F RID: 41583
			[Token(Token = "0x400A26F")]
			LoadoutType_NEW
		}

		// Token: 0x02001C14 RID: 7188
		[Token(Token = "0x2001C14")]
		public enum StoreQuality
		{
			// Token: 0x0400A271 RID: 41585
			[Token(Token = "0x400A271")]
			StoreQuality_NONE,
			// Token: 0x0400A272 RID: 41586
			[Token(Token = "0x400A272")]
			StoreQuality_WHITE,
			// Token: 0x0400A273 RID: 41587
			[Token(Token = "0x400A273")]
			StoreQuality_GREEN,
			// Token: 0x0400A274 RID: 41588
			[Token(Token = "0x400A274")]
			StoreQuality_BLUE,
			// Token: 0x0400A275 RID: 41589
			[Token(Token = "0x400A275")]
			StoreQuality_PURPLE,
			// Token: 0x0400A276 RID: 41590
			[Token(Token = "0x400A276")]
			StoreQuality_ORANGE,
			// Token: 0x0400A277 RID: 41591
			[Token(Token = "0x400A277")]
			StoreQuality_Red = 7
		}

		// Token: 0x02001C15 RID: 7189
		[Token(Token = "0x2001C15")]
		public enum PetSubType
		{
			// Token: 0x0400A279 RID: 41593
			[Token(Token = "0x400A279")]
			PetSubType_NONE,
			// Token: 0x0400A27A RID: 41594
			[Token(Token = "0x400A27A")]
			PetSubType_PET_AND_FOOD,
			// Token: 0x0400A27B RID: 41595
			[Token(Token = "0x400A27B")]
			PetSubType_PET_ANIM,
			// Token: 0x0400A27C RID: 41596
			[Token(Token = "0x400A27C")]
			PetSubType_PET_SKIN,
			// Token: 0x0400A27D RID: 41597
			[Token(Token = "0x400A27D")]
			PetSubType_PET_CHEST,
			// Token: 0x0400A27E RID: 41598
			[Token(Token = "0x400A27E")]
			PetSubType_PET_BOX
		}

		// Token: 0x02001C16 RID: 7190
		[Token(Token = "0x2001C16")]
		public enum ItemSubType
		{
			// Token: 0x0400A280 RID: 41600
			[Token(Token = "0x400A280")]
			ItemSubType_NONE,
			// Token: 0x0400A281 RID: 41601
			[Token(Token = "0x400A281")]
			ItemSubType_GACHACOUPON = 2,
			// Token: 0x0400A282 RID: 41602
			[Token(Token = "0x400A282")]
			ItemSubType_ELITEPASS,
			// Token: 0x0400A283 RID: 41603
			[Token(Token = "0x400A283")]
			ItemSubType_VOUCHER,
			// Token: 0x0400A284 RID: 41604
			[Token(Token = "0x400A284")]
			ItemSubType_RENAMECARD,
			// Token: 0x0400A285 RID: 41605
			[Token(Token = "0x400A285")]
			ItemSubType_REDENVELOPE,
			// Token: 0x0400A286 RID: 41606
			[Token(Token = "0x400A286")]
			ItemSubType_PETFOOD,
			// Token: 0x0400A287 RID: 41607
			[Token(Token = "0x400A287")]
			ItemSubType_FORGECURRENCY,
			// Token: 0x0400A288 RID: 41608
			[Token(Token = "0x400A288")]
			ItemSubType_PETANIM,
			// Token: 0x0400A289 RID: 41609
			[Token(Token = "0x400A289")]
			ItemSubType_PETSKIN,
			// Token: 0x0400A28A RID: 41610
			[Token(Token = "0x400A28A")]
			ItemSubType_REVIVETOKEN,
			// Token: 0x0400A28B RID: 41611
			[Token(Token = "0x400A28B")]
			ItemSubType_CHARACTER_PROFILE_UPGRADE_CARD,
			// Token: 0x0400A28C RID: 41612
			[Token(Token = "0x400A28C")]
			ItemSubType_CHIP,
			// Token: 0x0400A28D RID: 41613
			[Token(Token = "0x400A28D")]
			ItemSubType_PetSkill = 15,
			// Token: 0x0400A28E RID: 41614
			[Token(Token = "0x400A28E")]
			ItemSubType_CrateBox,
			// Token: 0x0400A28F RID: 41615
			[Token(Token = "0x400A28F")]
			ItemSubType_UNIVERSALDEBRIS,
			// Token: 0x0400A290 RID: 41616
			[Token(Token = "0x400A290")]
			ItemSubType_GACHACOUPON_LIMIT = 19,
			// Token: 0x0400A291 RID: 41617
			[Token(Token = "0x400A291")]
			ItemSubType_EVENTITEMFORHISTORY
		}

		// Token: 0x02001C17 RID: 7191
		[Token(Token = "0x2001C17")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB68C", Offset = "0x10FB68C")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06009C8E RID: 40078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009C8E")]
			[Address(RVA = "0x14F374C", Offset = "0x14F374C", VA = "0x7BBBCF374C")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06009C8F RID: 40079 RVA: 0x00029190 File Offset: 0x00027390
			[Token(Token = "0x6009C8F")]
			[Address(RVA = "0x14F3924", Offset = "0x14F3924", VA = "0x7BBBCF3924")]
			internal bool <FindIpTagDescByID>b__0(IPTagConfigDesc d)
			{
				return default(bool);
			}

			// Token: 0x0400A292 RID: 41618
			[Token(Token = "0x400A292")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}
	}
}
