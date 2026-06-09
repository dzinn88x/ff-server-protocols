using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ED5 RID: 7893
	[Token(Token = "0x2001ED5")]
	internal class UIModelInventory : UIBaseModel
	{
		// Token: 0x0600AD41 RID: 44353 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		[Token(Token = "0x600AD41")]
		[Address(RVA = "0x236EF4C", Offset = "0x236EF4C", VA = "0x7BBCB6EF4C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600AD42 RID: 44354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AD43 RID: 44355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B72")]
		public CSGetBackpackRes BackpackData
		{
			[Token(Token = "0x600AD42")]
			[Address(RVA = "0x236EF54", Offset = "0x236EF54", VA = "0x7BBCB6EF54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464DC", Offset = "0x11464DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AD43")]
			[Address(RVA = "0x236EF5C", Offset = "0x236EF5C", VA = "0x7BBCB6EF5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464EC", Offset = "0x11464EC")]
			private set
			{
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AD45 RID: 44357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B73")]
		public Item[] NewInventories
		{
			[Token(Token = "0x600AD44")]
			[Address(RVA = "0x236EF64", Offset = "0x236EF64", VA = "0x7BBCB6EF64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11464FC", Offset = "0x11464FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AD45")]
			[Address(RVA = "0x236EF6C", Offset = "0x236EF6C", VA = "0x7BBCB6EF6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114650C", Offset = "0x114650C")]
			private set
			{
			}
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD46")]
		[Address(RVA = "0x236EF74", Offset = "0x236EF74", VA = "0x7BBCB6EF74")]
		public List<InventoryItemInfo> CachedNewInventories()
		{
			return null;
		}

		// Token: 0x0600AD47 RID: 44359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD47")]
		[Address(RVA = "0x236EF7C", Offset = "0x236EF7C", VA = "0x7BBCB6EF7C")]
		public List<uint> SelectedLoadouts()
		{
			return null;
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B74")]
		public List<InventoryTopupNtf> TopupNotifications
		{
			[Token(Token = "0x600AD48")]
			[Address(RVA = "0x236EF84", Offset = "0x236EF84", VA = "0x7BBCB6EF84")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600AD49 RID: 44361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B75")]
		public List<Item> GachaCouponList
		{
			[Token(Token = "0x600AD49")]
			[Address(RVA = "0x236EF8C", Offset = "0x236EF8C", VA = "0x7BBCB6EF8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B76")]
		public List<uint> CacheLimitAvatar
		{
			[Token(Token = "0x600AD4A")]
			[Address(RVA = "0x236EF94", Offset = "0x236EF94", VA = "0x7BBCB6EF94")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B77")]
		public uint ChipCount
		{
			[Token(Token = "0x600AD4B")]
			[Address(RVA = "0x236EF9C", Offset = "0x236EF9C", VA = "0x7BBCB6EF9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114651C", Offset = "0x114651C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600AD4C")]
			[Address(RVA = "0x236EFA4", Offset = "0x236EFA4", VA = "0x7BBCB6EFA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114652C", Offset = "0x114652C")]
			private set
			{
			}
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4D")]
		[Address(RVA = "0x236EFAC", Offset = "0x236EFAC", VA = "0x7BBCB6EFAC", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4E")]
		[Address(RVA = "0x236F1D0", Offset = "0x236F1D0", VA = "0x7BBCB6F1D0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD4F")]
		[Address(RVA = "0x236F354", Offset = "0x236F354", VA = "0x7BBCB6F354")]
		public void OnTopupNtf(List<InventoryTopupNtf> topupNtfs)
		{
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD50")]
		[Address(RVA = "0x236F4BC", Offset = "0x236F4BC", VA = "0x7BBCB6F4BC")]
		public void RequestWallet(bool isRebateCard)
		{
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD51")]
		[Address(RVA = "0x236F734", Offset = "0x236F734", VA = "0x7BBCB6F734")]
		public void RequestBackpack(uint httpOp = 0U)
		{
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD52")]
		[Address(RVA = "0x236F928", Offset = "0x236F928", VA = "0x7BBCB6F928")]
		public void RequestLegendClothDesc(uint legendClothId = 0U, bool forceReq = false, uint httpOp = 0U)
		{
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD53")]
		[Address(RVA = "0x236FC50", Offset = "0x236FC50", VA = "0x7BBCB6FC50")]
		private void RefreshLegendClothDesc(CSGetLegendClothesDescRes res, bool refreshAll)
		{
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD54")]
		[Address(RVA = "0x236FDF4", Offset = "0x236FDF4", VA = "0x7BBCB6FDF4")]
		public void RequestInstallmentItems(uint httpOp = 0U)
		{
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD55")]
		[Address(RVA = "0x236FFC8", Offset = "0x236FFC8", VA = "0x7BBCB6FFC8")]
		private void LockOverDueAvatar()
		{
		}

		// Token: 0x0600AD56 RID: 44374 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		[Token(Token = "0x600AD56")]
		[Address(RVA = "0x2370234", Offset = "0x2370234", VA = "0x7BBCB70234")]
		public bool CheckIsUniqueAndOwned(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x0002FF10 File Offset: 0x0002E110
		[Token(Token = "0x600AD57")]
		[Address(RVA = "0x23703FC", Offset = "0x23703FC", VA = "0x7BBCB703FC")]
		private bool CheckHasUsingLockItem()
		{
			return default(bool);
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD58")]
		[Address(RVA = "0x2370798", Offset = "0x2370798", VA = "0x7BBCB70798")]
		public Dictionary<uint, Item> GetLoadOutDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD59 RID: 44377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD59")]
		[Address(RVA = "0x23707A0", Offset = "0x23707A0", VA = "0x7BBCB707A0")]
		public Dictionary<uint, Item> GetTreasureboxDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5A")]
		[Address(RVA = "0x23707A8", Offset = "0x23707A8", VA = "0x7BBCB707A8")]
		public Dictionary<uint, Item> GetFaceDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5B")]
		[Address(RVA = "0x23707B0", Offset = "0x23707B0", VA = "0x7BBCB707B0")]
		public Dictionary<uint, Item> GetClothDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5C")]
		[Address(RVA = "0x23707B8", Offset = "0x23707B8", VA = "0x7BBCB707B8")]
		public Dictionary<uint, Item> GetBundleDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5D")]
		[Address(RVA = "0x23707C0", Offset = "0x23707C0", VA = "0x7BBCB707C0")]
		public Dictionary<uint, Item> GetRoomCardDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5E")]
		[Address(RVA = "0x23707C8", Offset = "0x23707C8", VA = "0x7BBCB707C8")]
		public Dictionary<uint, Item> GetExchangeCurrencyInfo()
		{
			return null;
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD5F")]
		[Address(RVA = "0x23707D0", Offset = "0x23707D0", VA = "0x7BBCB707D0")]
		public Dictionary<uint, Item> GetDebrisDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD60")]
		[Address(RVA = "0x23707D8", Offset = "0x23707D8", VA = "0x7BBCB707D8")]
		public Dictionary<uint, Item> GetGrowthCardDictInfo()
		{
			return null;
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD61")]
		[Address(RVA = "0x23707E0", Offset = "0x23707E0", VA = "0x7BBCB707E0")]
		public void UpdateReminderItems(InventoryChangeMessage res)
		{
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD62")]
		[Address(RVA = "0x2370934", Offset = "0x2370934", VA = "0x7BBCB70934")]
		public void UpdateInstallmentsInfo(InventoryChangeMessage res, tcp.EInventory.Proto type)
		{
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD63")]
		[Address(RVA = "0x2371224", Offset = "0x2371224", VA = "0x7BBCB71224")]
		public void UpdateBackPackInfo(InventoryChangeMessage res)
		{
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD64")]
		[Address(RVA = "0x237325C", Offset = "0x237325C", VA = "0x7BBCB7325C")]
		public InventoryItemInfo FindItemInCacheNewInventory(uint itemID)
		{
			return null;
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD65")]
		[Address(RVA = "0x2371920", Offset = "0x2371920", VA = "0x7BBCB71920")]
		private void UpdateCachedNewInventory(Item it, [Optional] Item origItem)
		{
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD66")]
		[Address(RVA = "0x2371DCC", Offset = "0x2371DCC", VA = "0x7BBCB71DCC")]
		public void UpdateBackPackInfo(CSGetBackpackRes res, bool isTcpNtf = false)
		{
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x0002FF28 File Offset: 0x0002E128
		[Token(Token = "0x600AD67")]
		[Address(RVA = "0x23739FC", Offset = "0x23739FC", VA = "0x7BBCB739FC")]
		public bool IsValidLoadout(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x0002FF40 File Offset: 0x0002E140
		[Token(Token = "0x600AD68")]
		[Address(RVA = "0x2373C00", Offset = "0x2373C00", VA = "0x7BBCB73C00")]
		public bool CanUsePlayCard(Item PlayCardData)
		{
			return default(bool);
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD69")]
		[Address(RVA = "0x2373C98", Offset = "0x2373C98", VA = "0x7BBCB73C98")]
		public void ChooseLoadOut(uint itemIdold, uint itemIdnew, bool v = false)
		{
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD6A")]
		[Address(RVA = "0x23737D4", Offset = "0x23737D4", VA = "0x7BBCB737D4")]
		private void UpdateSelectedLoadouts(List<proto.LoadoutInfo> selectedinfo)
		{
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD6B")]
		[Address(RVA = "0x2371AC8", Offset = "0x2371AC8", VA = "0x7BBCB71AC8")]
		public void UpdateNewInventories()
		{
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD6C")]
		[Address(RVA = "0x237409C", Offset = "0x237409C", VA = "0x7BBCB7409C")]
		public Item GetItemById(uint iid)
		{
			return null;
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD6D")]
		[Address(RVA = "0x2374180", Offset = "0x2374180", VA = "0x7BBCB74180")]
		public Item GetInstallmentItemById(uint id)
		{
			return null;
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x0002FF58 File Offset: 0x0002E158
		[Token(Token = "0x600AD6E")]
		[Address(RVA = "0x2373BE4", Offset = "0x2373BE4", VA = "0x7BBCB73BE4")]
		public int GetItemCount(uint iid)
		{
			return 0;
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD6F")]
		[Address(RVA = "0x2373A5C", Offset = "0x2373A5C", VA = "0x7BBCB73A5C")]
		public Item GetPlayCardById(uint id)
		{
			return null;
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x0002FF70 File Offset: 0x0002E170
		[Token(Token = "0x600AD70")]
		[Address(RVA = "0x237425C", Offset = "0x237425C", VA = "0x7BBCB7425C")]
		public bool IsInstallmentItem(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x0002FF88 File Offset: 0x0002E188
		[Token(Token = "0x600AD71")]
		[Address(RVA = "0x2374280", Offset = "0x2374280", VA = "0x7BBCB74280")]
		public bool IsInstallmentItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x0002FFA0 File Offset: 0x0002E1A0
		[Token(Token = "0x600AD72")]
		[Address(RVA = "0x237429C", Offset = "0x237429C", VA = "0x7BBCB7429C")]
		public bool IsReminderItem(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD73")]
		[Address(RVA = "0x23742C8", Offset = "0x23742C8", VA = "0x7BBCB742C8")]
		public Item FindReminderItemByID(uint id)
		{
			return null;
		}

		// Token: 0x0600AD74 RID: 44404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD74")]
		[Address(RVA = "0x2371838", Offset = "0x2371838", VA = "0x7BBCB71838")]
		public void RemoveReminderItem(Item item)
		{
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		[Token(Token = "0x600AD75")]
		[Address(RVA = "0x237038C", Offset = "0x237038C", VA = "0x7BBCB7038C")]
		public bool ContainsItemIDInBackpack(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		[Token(Token = "0x600AD76")]
		[Address(RVA = "0x23743A4", Offset = "0x23743A4", VA = "0x7BBCB743A4")]
		public bool IsLockItem(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[Token(Token = "0x600AD77")]
		[Address(RVA = "0x2370218", Offset = "0x2370218", VA = "0x7BBCB70218")]
		public bool IsLockItem(Item item)
		{
			return default(bool);
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD78")]
		[Address(RVA = "0x23743C8", Offset = "0x23743C8", VA = "0x7BBCB743C8")]
		public List<Item> GetSortedLoadoutsList()
		{
			return null;
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD79")]
		[Address(RVA = "0x23743D0", Offset = "0x23743D0", VA = "0x7BBCB743D0")]
		public List<Item> GetSortedLoadoutsListByType(CSSharedItemDataManager.LoadoutSubType type)
		{
			return null;
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD7A")]
		[Address(RVA = "0x23743FC", Offset = "0x23743FC", VA = "0x7BBCB743FC")]
		public List<Item> GetSortedGrowthCardList()
		{
			return null;
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD7B")]
		[Address(RVA = "0x2374404", Offset = "0x2374404", VA = "0x7BBCB74404")]
		public List<InventoryItemInfo> GetInventoryItemList(List<Item> itemList)
		{
			return null;
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD7C")]
		[Address(RVA = "0x2374570", Offset = "0x2374570", VA = "0x7BBCB74570")]
		public List<Item> GetShowInInventoryPropList()
		{
			return null;
		}

		// Token: 0x0600AD7D RID: 44413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD7D")]
		[Address(RVA = "0x2374578", Offset = "0x2374578", VA = "0x7BBCB74578")]
		public List<Item> GetInstallmentItemList()
		{
			return null;
		}

		// Token: 0x0600AD7E RID: 44414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD7E")]
		[Address(RVA = "0x2374580", Offset = "0x2374580", VA = "0x7BBCB74580")]
		public void UpdatePreviewClothItem(InventoryClothInfo cInfo)
		{
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD7F")]
		[Address(RVA = "0x23745B4", Offset = "0x23745B4", VA = "0x7BBCB745B4")]
		public void UpdateClothNewOwnedState(AvatarWardrobeData cloth)
		{
		}

		// Token: 0x0600AD80 RID: 44416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD80")]
		[Address(RVA = "0x237471C", Offset = "0x237471C", VA = "0x7BBCB7471C")]
		public void RemoveItemInNewItemCache(uint itemID)
		{
		}

		// Token: 0x0600AD81 RID: 44417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD81")]
		[Address(RVA = "0x2373504", Offset = "0x2373504", VA = "0x7BBCB73504")]
		public void RemoveItemInNewItemCache(InventoryItemInfo info)
		{
		}

		// Token: 0x0600AD82 RID: 44418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD82")]
		[Address(RVA = "0x2374758", Offset = "0x2374758", VA = "0x7BBCB74758")]
		public void UpdateAllTipsNum()
		{
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD83")]
		[Address(RVA = "0x2374874", Offset = "0x2374874", VA = "0x7BBCB74874")]
		public void UpdateTreasureBoxTipsNum()
		{
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD84")]
		[Address(RVA = "0x237487C", Offset = "0x237487C", VA = "0x7BBCB7487C")]
		public void UpdateBundleTipsNum()
		{
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD85")]
		[Address(RVA = "0x2374884", Offset = "0x2374884", VA = "0x7BBCB74884")]
		public void UpdateGrowthCardTipsNum()
		{
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD86")]
		[Address(RVA = "0x2373334", Offset = "0x2373334", VA = "0x7BBCB73334")]
		private void UpdateTipsNum(InventoryItemInfo infoInNewCache, int num)
		{
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD87")]
		[Address(RVA = "0x2374BE0", Offset = "0x2374BE0", VA = "0x7BBCB74BE0")]
		public void UpdateTipsNum(uint itemID)
		{
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD88")]
		[Address(RVA = "0x2370868", Offset = "0x2370868", VA = "0x7BBCB70868")]
		public void UpdateReminderTipsNum()
		{
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x00030000 File Offset: 0x0002E200
		[Token(Token = "0x600AD89")]
		[Address(RVA = "0x2374B88", Offset = "0x2374B88", VA = "0x7BBCB74B88")]
		public bool CheckIsAvaliableItem(InventoryItemInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x00030018 File Offset: 0x0002E218
		[Token(Token = "0x600AD8A")]
		[Address(RVA = "0x2374C24", Offset = "0x2374C24", VA = "0x7BBCB74C24")]
		public bool CheckIsAvaliableCloth(InventoryItemInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x00030030 File Offset: 0x0002E230
		[Token(Token = "0x600AD8B")]
		[Address(RVA = "0x2373574", Offset = "0x2373574", VA = "0x7BBCB73574")]
		public bool IsShowInInventoryPropItem(InventoryItemInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x00030048 File Offset: 0x0002E248
		[Token(Token = "0x600AD8C")]
		[Address(RVA = "0x2374A5C", Offset = "0x2374A5C", VA = "0x7BBCB74A5C")]
		public ETipsType GetTipsType(InventoryItemInfo info)
		{
			return ETipsType.None;
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x00030060 File Offset: 0x0002E260
		[Token(Token = "0x600AD8D")]
		[Address(RVA = "0x2374DB8", Offset = "0x2374DB8", VA = "0x7BBCB74DB8")]
		public ETipsType GetTipsType(UIModelAvatarBase.EWardrobeType wType)
		{
			return ETipsType.None;
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x00030078 File Offset: 0x0002E278
		[Token(Token = "0x600AD8E")]
		[Address(RVA = "0x2374E6C", Offset = "0x2374E6C", VA = "0x7BBCB74E6C")]
		public ETipsType GetTipsType(CSSharedItemDataManager.ItemType itemType)
		{
			return ETipsType.None;
		}

		// Token: 0x0600AD8F RID: 44431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD8F")]
		[Address(RVA = "0x2374798", Offset = "0x2374798", VA = "0x7BBCB74798")]
		public void UpdateAllClothTipsNum()
		{
		}

		// Token: 0x0600AD90 RID: 44432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD90")]
		[Address(RVA = "0x237488C", Offset = "0x237488C", VA = "0x7BBCB7488C")]
		public void UpdateTipsNum(CSSharedItemDataManager.ItemType itType)
		{
		}

		// Token: 0x0600AD91 RID: 44433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD91")]
		[Address(RVA = "0x2374F20", Offset = "0x2374F20", VA = "0x7BBCB74F20")]
		public void UpdateTipsNum(UIModelAvatarBase.EWardrobeType wType)
		{
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x00030090 File Offset: 0x0002E290
		[Token(Token = "0x600AD92")]
		[Address(RVA = "0x2374F80", Offset = "0x2374F80", VA = "0x7BBCB74F80")]
		public int GetTipNum(UIModelAvatarBase.EWardrobeType wType, bool epicOnly = false, bool legendOnly = false)
		{
			return 0;
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD93")]
		[Address(RVA = "0x2371784", Offset = "0x2371784", VA = "0x7BBCB71784")]
		private void SetTipsNum(ETipsType tipsType, int number = 0)
		{
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x000300A8 File Offset: 0x0002E2A8
		[Token(Token = "0x600AD94")]
		[Address(RVA = "0x2375278", Offset = "0x2375278", VA = "0x7BBCB75278")]
		public bool HaveOwnedPermanetUniqueItem(uint id, bool checkInstallment = false)
		{
			return default(bool);
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x000300C0 File Offset: 0x0002E2C0
		[Token(Token = "0x600AD95")]
		[Address(RVA = "0x23753F4", Offset = "0x23753F4", VA = "0x7BBCB753F4")]
		public bool HasRoomCard(proto.EInventory.ItemSubType type)
		{
			return default(bool);
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x000300D8 File Offset: 0x0002E2D8
		[Token(Token = "0x600AD96")]
		[Address(RVA = "0x2375550", Offset = "0x2375550", VA = "0x7BBCB75550")]
		public uint GetRoomCardCount(proto.EInventory.ItemSubType type)
		{
			return 0U;
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x000300F0 File Offset: 0x0002E2F0
		[Token(Token = "0x600AD97")]
		[Address(RVA = "0x23756BC", Offset = "0x23756BC", VA = "0x7BBCB756BC")]
		public uint GetRoomCardExpiredTime(proto.EInventory.ItemSubType type)
		{
			return 0U;
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD98")]
		[Address(RVA = "0x237581C", Offset = "0x237581C", VA = "0x7BBCB7581C")]
		public void SetPurchaseFlag(bool state)
		{
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x00030108 File Offset: 0x0002E308
		[Token(Token = "0x600AD99")]
		[Address(RVA = "0x2375828", Offset = "0x2375828", VA = "0x7BBCB75828")]
		public bool GetPurchaseFlag()
		{
			return default(bool);
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD9A")]
		[Address(RVA = "0x2375830", Offset = "0x2375830", VA = "0x7BBCB75830")]
		public UIModelInventory()
		{
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD9B")]
		[Address(RVA = "0x2375E98", Offset = "0x2375E98", VA = "0x7BBCB75E98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114653C", Offset = "0x114653C")]
		private void <RequestBackpack>b__68_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD9C")]
		[Address(RVA = "0x237631C", Offset = "0x237631C", VA = "0x7BBCB7631C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114654C", Offset = "0x114654C")]
		private void <RequestInstallmentItems>b__72_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x00030120 File Offset: 0x0002E320
		[Token(Token = "0x600AD9D")]
		[Address(RVA = "0x23765B4", Offset = "0x23765B4", VA = "0x7BBCB765B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114655C", Offset = "0x114655C")]
		private bool <ChooseLoadOut>b__93_1(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD9E")]
		[Address(RVA = "0x23765B8", Offset = "0x23765B8", VA = "0x7BBCB765B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114656C", Offset = "0x114656C")]
		private void <ChooseLoadOut>b__93_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x00030138 File Offset: 0x0002E338
		[Token(Token = "0x600AD9F")]
		[Address(RVA = "0x23766BC", Offset = "0x23766BC", VA = "0x7BBCB766BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114657C", Offset = "0x114657C")]
		private bool <UpdateNewInventories>b__95_0(Item it)
		{
			return default(bool);
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x00030150 File Offset: 0x0002E350
		[Token(Token = "0x600ADA0")]
		[Address(RVA = "0x2376748", Offset = "0x2376748", VA = "0x7BBCB76748")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114658C", Offset = "0x114658C")]
		private bool <UpdateNewInventories>b__95_1(Item it)
		{
			return default(bool);
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x00030168 File Offset: 0x0002E368
		[Token(Token = "0x600ADA1")]
		[Address(RVA = "0x23767D4", Offset = "0x23767D4", VA = "0x7BBCB767D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114659C", Offset = "0x114659C")]
		private bool <UpdateNewInventories>b__95_2(Item it)
		{
			return default(bool);
		}

		// Token: 0x0400B190 RID: 45456
		[Token(Token = "0x400B190")]
		public const uint PropID_InventoryBagpack = 2U;

		// Token: 0x0400B191 RID: 45457
		[Token(Token = "0x400B191")]
		public const uint PropID_InventoryNew = 4U;

		// Token: 0x0400B192 RID: 45458
		[Token(Token = "0x400B192")]
		public const uint PropID_InventoryBagpackChanged = 8U;

		// Token: 0x0400B193 RID: 45459
		[Token(Token = "0x400B193")]
		public const uint PropID_InventoryTopupNotification = 16U;

		// Token: 0x0400B194 RID: 45460
		[Token(Token = "0x400B194")]
		public const uint PropID_InventoryInstallmentItems = 32U;

		// Token: 0x0400B195 RID: 45461
		[Token(Token = "0x400B195")]
		public const uint PropID_InventoryInstallmentItemsChanged = 64U;

		// Token: 0x0400B196 RID: 45462
		[Token(Token = "0x400B196")]
		public const uint PropID_InventoryFetchLegendClothDesc = 128U;

		// Token: 0x0400B197 RID: 45463
		[Token(Token = "0x400B197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isLogin;

		// Token: 0x0400B198 RID: 45464
		[Token(Token = "0x400B198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool purchase_flag;

		// Token: 0x0400B199 RID: 45465
		[Token(Token = "0x400B199")]
		private const string INVENTORY_LOADOUT_KEY = "inventory_loadout";

		// Token: 0x0400B19A RID: 45466
		[Token(Token = "0x400B19A")]
		public const string NORMAL_LOADOUT_GUIDE_KEY = "normal_loadout_guide";

		// Token: 0x0400B19B RID: 45467
		[Token(Token = "0x400B19B")]
		public const string ADVANCE_LOADOUT_GUIDE_KEY = "advance_loadout_guide";

		// Token: 0x0400B19C RID: 45468
		[Token(Token = "0x400B19C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<CSSharedItemDataManager.ItemType, ETipsType> InvTypeToTipsMap;

		// Token: 0x0400B19D RID: 45469
		[Token(Token = "0x400B19D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<UIModelAvatarBase.EWardrobeType, ETipsType> clothTypeToTipsMap;

		// Token: 0x0400B19E RID: 45470
		[Token(Token = "0x400B19E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<uint> PlayedAnimItem;

		// Token: 0x0400B19F RID: 45471
		[Token(Token = "0x400B19F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300CC", Offset = "0x11300CC")]
		private CSGetBackpackRes <BackpackData>k__BackingField;

		// Token: 0x0400B1A0 RID: 45472
		[Token(Token = "0x400B1A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300DC", Offset = "0x11300DC")]
		private Item[] <NewInventories>k__BackingField;

		// Token: 0x0400B1A1 RID: 45473
		[Token(Token = "0x400B1A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<InventoryItemInfo> m_CachedNewInventories;

		// Token: 0x0400B1A2 RID: 45474
		[Token(Token = "0x400B1A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<Vector2, LegendClothUnlockDesc> LegendClothLevelConfigs;

		// Token: 0x0400B1A3 RID: 45475
		[Token(Token = "0x400B1A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<uint> m_SelectedLoadouts;

		// Token: 0x0400B1A4 RID: 45476
		[Token(Token = "0x400B1A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<UIModelAvatarBase.EGenderType, List<CSSharedAvatarData>> m_DictBackpackAvatar;

		// Token: 0x0400B1A5 RID: 45477
		[Token(Token = "0x400B1A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<UIModelAvatarBase.EWardrobeType, List<InventoryClothInfo>> m_DictBackpackCloth;

		// Token: 0x0400B1A6 RID: 45478
		[Token(Token = "0x400B1A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<uint, Item> m_DictFaceInfo;

		// Token: 0x0400B1A7 RID: 45479
		[Token(Token = "0x400B1A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<uint, Item> m_DictClothInfo;

		// Token: 0x0400B1A8 RID: 45480
		[Token(Token = "0x400B1A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<uint, Item> m_DictLoadoutInfo;

		// Token: 0x0400B1A9 RID: 45481
		[Token(Token = "0x400B1A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<uint, Item> m_DictTreasureBoxInfo;

		// Token: 0x0400B1AA RID: 45482
		[Token(Token = "0x400B1AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<uint, Item> m_DictDebrisInfo;

		// Token: 0x0400B1AB RID: 45483
		[Token(Token = "0x400B1AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<uint, Item> m_DictBundleInfo;

		// Token: 0x0400B1AC RID: 45484
		[Token(Token = "0x400B1AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<uint, Item> m_DictExchangeCurrency;

		// Token: 0x0400B1AD RID: 45485
		[Token(Token = "0x400B1AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, Item> m_DictGrowthCardInfo;

		// Token: 0x0400B1AE RID: 45486
		[Token(Token = "0x400B1AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<uint, Item> m_DictRoomCardInfo;

		// Token: 0x0400B1AF RID: 45487
		[Token(Token = "0x400B1AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HashSet<uint> m_BackpackItemIDCache;

		// Token: 0x0400B1B0 RID: 45488
		[Token(Token = "0x400B1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<Item> m_SortedLoadoutList;

		// Token: 0x0400B1B1 RID: 45489
		[Token(Token = "0x400B1B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Item> m_SortedOldLoadoutList;

		// Token: 0x0400B1B2 RID: 45490
		[Token(Token = "0x400B1B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Item> m_SortedNewLoadoutList;

		// Token: 0x0400B1B3 RID: 45491
		[Token(Token = "0x400B1B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Item> m_SortedGrowthCardList;

		// Token: 0x0400B1B4 RID: 45492
		[Token(Token = "0x400B1B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<Item> m_PlayCardList;

		// Token: 0x0400B1B5 RID: 45493
		[Token(Token = "0x400B1B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<Item> m_ShowInInventoryPropList;

		// Token: 0x0400B1B6 RID: 45494
		[Token(Token = "0x400B1B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<InventoryTopupNtf> _TopupNotifications;

		// Token: 0x0400B1B7 RID: 45495
		[Token(Token = "0x400B1B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<ServiceMessageTypeHTTP> m_PendingRequest;

		// Token: 0x0400B1B8 RID: 45496
		[Token(Token = "0x400B1B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<Item> m_InstallmentItemsList;

		// Token: 0x0400B1B9 RID: 45497
		[Token(Token = "0x400B1B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<Item> m_ReminderItemsList;

		// Token: 0x0400B1BA RID: 45498
		[Token(Token = "0x400B1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<Item> m_GachaCouponList;

		// Token: 0x0400B1BB RID: 45499
		[Token(Token = "0x400B1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<uint> m_CacheLimitAvatar;

		// Token: 0x0400B1BC RID: 45500
		[Token(Token = "0x400B1BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11300EC", Offset = "0x11300EC")]
		private uint <ChipCount>k__BackingField;

		// Token: 0x0400B1BD RID: 45501
		[Token(Token = "0x400B1BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public bool NeedShowLegendVaultColorTip;

		// Token: 0x02001ED6 RID: 7894
		[Token(Token = "0x2001ED6")]
		public class NotifyInstallmentArgs
		{
			// Token: 0x0600ADA2 RID: 44450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADA2")]
			[Address(RVA = "0x23765AC", Offset = "0x23765AC", VA = "0x7BBCB765AC")]
			public NotifyInstallmentArgs()
			{
			}

			// Token: 0x0400B1BE RID: 45502
			[Token(Token = "0x400B1BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool requestProfile;
		}

		// Token: 0x02001ED7 RID: 7895
		[Token(Token = "0x2001ED7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBA4", Offset = "0x10FCBA4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600ADA4 RID: 44452 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADA4")]
			[Address(RVA = "0x23768C4", Offset = "0x23768C4", VA = "0x7BBCB768C4")]
			public <>c()
			{
			}

			// Token: 0x0600ADA5 RID: 44453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADA5")]
			[Address(RVA = "0x23768CC", Offset = "0x23768CC", VA = "0x7BBCB768CC")]
			internal void <RequestWallet>b__67_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600ADA6 RID: 44454 RVA: 0x00030180 File Offset: 0x0002E380
			[Token(Token = "0x600ADA6")]
			[Address(RVA = "0x2376AB0", Offset = "0x2376AB0", VA = "0x7BBCB76AB0")]
			internal int <UpdateBackPackInfo>b__90_0(Item a, Item b)
			{
				return 0;
			}

			// Token: 0x0600ADA7 RID: 44455 RVA: 0x00030198 File Offset: 0x0002E398
			[Token(Token = "0x600ADA7")]
			[Address(RVA = "0x2376AF8", Offset = "0x2376AF8", VA = "0x7BBCB76AF8")]
			internal int <UpdateBackPackInfo>b__90_1(Item a, Item b)
			{
				return 0;
			}

			// Token: 0x0600ADA8 RID: 44456 RVA: 0x000301B0 File Offset: 0x0002E3B0
			[Token(Token = "0x600ADA8")]
			[Address(RVA = "0x2376B40", Offset = "0x2376B40", VA = "0x7BBCB76B40")]
			internal int <UpdateBackPackInfo>b__90_2(Item a, Item b)
			{
				return 0;
			}

			// Token: 0x0600ADA9 RID: 44457 RVA: 0x000301C8 File Offset: 0x0002E3C8
			[Token(Token = "0x600ADA9")]
			[Address(RVA = "0x2376B88", Offset = "0x2376B88", VA = "0x7BBCB76B88")]
			internal int <UpdateBackPackInfo>b__90_3(Item a, Item b)
			{
				return 0;
			}

			// Token: 0x0600ADAA RID: 44458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ADAA")]
			[Address(RVA = "0x2376BF0", Offset = "0x2376BF0", VA = "0x7BBCB76BF0")]
			internal string <UpdateSelectedLoadouts>b__94_0(uint iid)
			{
				return null;
			}

			// Token: 0x0400B1BF RID: 45503
			[Token(Token = "0x400B1BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelInventory.<>c <>9;

			// Token: 0x0400B1C0 RID: 45504
			[Token(Token = "0x400B1C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__67_0;

			// Token: 0x0400B1C1 RID: 45505
			[Token(Token = "0x400B1C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Item> <>9__90_0;

			// Token: 0x0400B1C2 RID: 45506
			[Token(Token = "0x400B1C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Item> <>9__90_1;

			// Token: 0x0400B1C3 RID: 45507
			[Token(Token = "0x400B1C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<Item> <>9__90_2;

			// Token: 0x0400B1C4 RID: 45508
			[Token(Token = "0x400B1C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Comparison<Item> <>9__90_3;

			// Token: 0x0400B1C5 RID: 45509
			[Token(Token = "0x400B1C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<uint, string> <>9__94_0;
		}

		// Token: 0x02001ED8 RID: 7896
		[Token(Token = "0x2001ED8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBB4", Offset = "0x10FCBB4")]
		private sealed class <>c__DisplayClass69_0
		{
			// Token: 0x0600ADAB RID: 44459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADAB")]
			[Address(RVA = "0x236FC48", Offset = "0x236FC48", VA = "0x7BBCB6FC48")]
			public <>c__DisplayClass69_0()
			{
			}

			// Token: 0x0600ADAC RID: 44460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADAC")]
			[Address(RVA = "0x2376C9C", Offset = "0x2376C9C", VA = "0x7BBCB76C9C")]
			internal void <RequestLegendClothDesc>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B1C6 RID: 45510
			[Token(Token = "0x400B1C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelInventory <>4__this;

			// Token: 0x0400B1C7 RID: 45511
			[Token(Token = "0x400B1C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool refreshAll;
		}

		// Token: 0x02001ED9 RID: 7897
		[Token(Token = "0x2001ED9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBC4", Offset = "0x10FCBC4")]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x0600ADAD RID: 44461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADAD")]
			[Address(RVA = "0x2371830", Offset = "0x2371830", VA = "0x7BBCB71830")]
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x0600ADAE RID: 44462 RVA: 0x000301E0 File Offset: 0x0002E3E0
			[Token(Token = "0x600ADAE")]
			[Address(RVA = "0x2376DDC", Offset = "0x2376DDC", VA = "0x7BBCB76DDC")]
			internal bool <UpdateInstallmentsInfo>b__0(Item a)
			{
				return default(bool);
			}

			// Token: 0x0600ADAF RID: 44463 RVA: 0x000301F8 File Offset: 0x0002E3F8
			[Token(Token = "0x600ADAF")]
			[Address(RVA = "0x2376E28", Offset = "0x2376E28", VA = "0x7BBCB76E28")]
			internal bool <UpdateInstallmentsInfo>b__1(Item a)
			{
				return default(bool);
			}

			// Token: 0x0400B1C8 RID: 45512
			[Token(Token = "0x400B1C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Item it;
		}

		// Token: 0x02001EDA RID: 7898
		[Token(Token = "0x2001EDA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBD4", Offset = "0x10FCBD4")]
		private sealed class <>c__DisplayClass86_1
		{
			// Token: 0x0600ADB0 RID: 44464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB0")]
			[Address(RVA = "0x2371910", Offset = "0x2371910", VA = "0x7BBCB71910")]
			public <>c__DisplayClass86_1()
			{
			}

			// Token: 0x0600ADB1 RID: 44465 RVA: 0x00030210 File Offset: 0x0002E410
			[Token(Token = "0x600ADB1")]
			[Address(RVA = "0x2376E74", Offset = "0x2376E74", VA = "0x7BBCB76E74")]
			internal bool <UpdateInstallmentsInfo>b__2(Item a)
			{
				return default(bool);
			}

			// Token: 0x0400B1C9 RID: 45513
			[Token(Token = "0x400B1C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Item it;
		}

		// Token: 0x02001EDB RID: 7899
		[Token(Token = "0x2001EDB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBE4", Offset = "0x10FCBE4")]
		private sealed class <>c__DisplayClass87_0
		{
			// Token: 0x0600ADB2 RID: 44466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB2")]
			[Address(RVA = "0x2371918", Offset = "0x2371918", VA = "0x7BBCB71918")]
			public <>c__DisplayClass87_0()
			{
			}

			// Token: 0x0600ADB3 RID: 44467 RVA: 0x00030228 File Offset: 0x0002E428
			[Token(Token = "0x600ADB3")]
			[Address(RVA = "0x2376EC0", Offset = "0x2376EC0", VA = "0x7BBCB76EC0")]
			internal bool <UpdateBackPackInfo>b__0(Item a)
			{
				return default(bool);
			}

			// Token: 0x0400B1CA RID: 45514
			[Token(Token = "0x400B1CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Item it;
		}

		// Token: 0x02001EDC RID: 7900
		[Token(Token = "0x2001EDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCBF4", Offset = "0x10FCBF4")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x0600ADB4 RID: 44468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB4")]
			[Address(RVA = "0x237332C", Offset = "0x237332C", VA = "0x7BBCB7332C")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x0600ADB5 RID: 44469 RVA: 0x00030240 File Offset: 0x0002E440
			[Token(Token = "0x600ADB5")]
			[Address(RVA = "0x2376F0C", Offset = "0x2376F0C", VA = "0x7BBCB76F0C")]
			internal bool <FindItemInCacheNewInventory>b__0(InventoryItemInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B1CB RID: 45515
			[Token(Token = "0x400B1CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint itemID;
		}

		// Token: 0x02001EDD RID: 7901
		[Token(Token = "0x2001EDD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC04", Offset = "0x10FCC04")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600ADB6 RID: 44470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB6")]
			[Address(RVA = "0x2374178", Offset = "0x2374178", VA = "0x7BBCB74178")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600ADB7 RID: 44471 RVA: 0x00030258 File Offset: 0x0002E458
			[Token(Token = "0x600ADB7")]
			[Address(RVA = "0x2376F2C", Offset = "0x2376F2C", VA = "0x7BBCB76F2C")]
			internal bool <GetItemById>b__0(Item item)
			{
				return default(bool);
			}

			// Token: 0x0400B1CC RID: 45516
			[Token(Token = "0x400B1CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint iid;
		}

		// Token: 0x02001EDE RID: 7902
		[Token(Token = "0x2001EDE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC14", Offset = "0x10FCC14")]
		private sealed class <>c__DisplayClass97_0
		{
			// Token: 0x0600ADB8 RID: 44472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADB8")]
			[Address(RVA = "0x2374254", Offset = "0x2374254", VA = "0x7BBCB74254")]
			public <>c__DisplayClass97_0()
			{
			}

			// Token: 0x0600ADB9 RID: 44473 RVA: 0x00030270 File Offset: 0x0002E470
			[Token(Token = "0x600ADB9")]
			[Address(RVA = "0x2376F68", Offset = "0x2376F68", VA = "0x7BBCB76F68")]
			internal bool <GetInstallmentItemById>b__0(Item item)
			{
				return default(bool);
			}

			// Token: 0x0400B1CD RID: 45517
			[Token(Token = "0x400B1CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001EDF RID: 7903
		[Token(Token = "0x2001EDF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC24", Offset = "0x10FCC24")]
		private sealed class <>c__DisplayClass103_0
		{
			// Token: 0x0600ADBA RID: 44474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBA")]
			[Address(RVA = "0x237439C", Offset = "0x237439C", VA = "0x7BBCB7439C")]
			public <>c__DisplayClass103_0()
			{
			}

			// Token: 0x0600ADBB RID: 44475 RVA: 0x00030288 File Offset: 0x0002E488
			[Token(Token = "0x600ADBB")]
			[Address(RVA = "0x2376C18", Offset = "0x2376C18", VA = "0x7BBCB76C18")]
			internal bool <FindReminderItemByID>b__0(Item item)
			{
				return default(bool);
			}

			// Token: 0x0400B1CE RID: 45518
			[Token(Token = "0x400B1CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x02001EE0 RID: 7904
		[Token(Token = "0x2001EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCC34", Offset = "0x10FCC34")]
		private sealed class <>c__DisplayClass115_0
		{
			// Token: 0x0600ADBC RID: 44476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ADBC")]
			[Address(RVA = "0x2374714", Offset = "0x2374714", VA = "0x7BBCB74714")]
			public <>c__DisplayClass115_0()
			{
			}

			// Token: 0x0600ADBD RID: 44477 RVA: 0x000302A0 File Offset: 0x0002E4A0
			[Token(Token = "0x600ADBD")]
			[Address(RVA = "0x2376C50", Offset = "0x2376C50", VA = "0x7BBCB76C50")]
			internal bool <UpdateClothNewOwnedState>b__0(InventoryClothInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B1CF RID: 45519
			[Token(Token = "0x400B1CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AvatarWardrobeData cloth;
		}
	}
}
