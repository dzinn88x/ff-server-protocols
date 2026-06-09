using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D06 RID: 7430
	[Token(Token = "0x2001D06")]
	public class RoomCreateRuleDataManager : SingletonModule<RoomCreateRuleDataManager>
	{
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9F")]
		public List<uint> GameModeIdList
		{
			[Token(Token = "0x600A1CE")]
			[Address(RVA = "0x1B2EDAC", Offset = "0x1B2EDAC", VA = "0x7BBC32EDAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1CF")]
		[Address(RVA = "0x1B2EE20", Offset = "0x1B2EE20", VA = "0x7BBC32EE20", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D0")]
		[Address(RVA = "0x1B2EE4C", Offset = "0x1B2EE4C", VA = "0x7BBC32EE4C")]
		private void LoadRoomCreateRuleHPEPData()
		{
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D1")]
		[Address(RVA = "0x1B2F1D8", Offset = "0x1B2F1D8", VA = "0x7BBC32F1D8")]
		private void LoadRoomCreateCSShop()
		{
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D2")]
		[Address(RVA = "0x1B2F5DC", Offset = "0x1B2F5DC", VA = "0x7BBC32F5DC")]
		private void LoadRoomCreateCSEco()
		{
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D3")]
		[Address(RVA = "0x1B2F800", Offset = "0x1B2F800", VA = "0x7BBC32F800")]
		public List<RoomCreateCSShopData> GetCSShopWeaponList(uint type)
		{
			return null;
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D4")]
		[Address(RVA = "0x1B2F8E0", Offset = "0x1B2F8E0", VA = "0x7BBC32F8E0")]
		public List<RoomCreateCSEcoData> GetCSEcoList()
		{
			return null;
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1D5")]
		[Address(RVA = "0x1B2F8E8", Offset = "0x1B2F8E8", VA = "0x7BBC32F8E8")]
		public List<uint> GetCSShopTypeTabList()
		{
			return null;
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D6")]
		[Address(RVA = "0x1B2F8F0", Offset = "0x1B2F8F0", VA = "0x7BBC32F8F0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0002A7B0 File Offset: 0x000289B0
		[Token(Token = "0x600A1D7")]
		[Address(RVA = "0x1B2FB6C", Offset = "0x1B2FB6C", VA = "0x7BBC32FB6C")]
		public bool IsRoomCreateRuleDropInited()
		{
			return default(bool);
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D8")]
		[Address(RVA = "0x1B2FB74", Offset = "0x1B2FB74", VA = "0x7BBC32FB74")]
		public void ClearRoomCreateRuleDrop()
		{
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1D9")]
		[Address(RVA = "0x1B2FB7C", Offset = "0x1B2FB7C", VA = "0x7BBC32FB7C")]
		public void UpdateRoomCreateRuleDrop(List<RoomCreateRuleDropDesc> list)
		{
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1DA")]
		[Address(RVA = "0x1B2FFC4", Offset = "0x1B2FFC4", VA = "0x7BBC32FFC4")]
		public List<uint> GetModeIDListByRoomType(uint roomType)
		{
			return null;
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1DB")]
		[Address(RVA = "0x1B30064", Offset = "0x1B30064", VA = "0x7BBC330064")]
		public List<uint> GetMapIDListByGameModeAndRoomType(uint roomType, uint gameMode)
		{
			return null;
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1DC")]
		[Address(RVA = "0x1B300FC", Offset = "0x1B300FC", VA = "0x7BBC3300FC")]
		public List<uint> GetMapConfigIDListByRoomType(uint roomType)
		{
			return null;
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1DD")]
		[Address(RVA = "0x1B3016C", Offset = "0x1B3016C", VA = "0x7BBC33016C")]
		public uint[] GetMembers(string key)
		{
			return null;
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1DE")]
		[Address(RVA = "0x1B301F0", Offset = "0x1B301F0", VA = "0x7BBC3301F0")]
		public uint[] GetSpectators(string key)
		{
			return null;
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x0002A7C8 File Offset: 0x000289C8
		[Token(Token = "0x600A1DF")]
		[Address(RVA = "0x1B30274", Offset = "0x1B30274", VA = "0x7BBC330274")]
		public uint GetMinMembersCount(string key)
		{
			return 0U;
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x0002A7E0 File Offset: 0x000289E0
		[Token(Token = "0x600A1E0")]
		[Address(RVA = "0x1B30310", Offset = "0x1B30310", VA = "0x7BBC330310")]
		public bool IsKeyValid(string key)
		{
			return default(bool);
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x0002A7F8 File Offset: 0x000289F8
		[Token(Token = "0x600A1E1")]
		[Address(RVA = "0x1B30380", Offset = "0x1B30380", VA = "0x7BBC330380")]
		public uint GetFirstMapConfig(uint roomType)
		{
			return 0U;
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E2")]
		[Address(RVA = "0x1B3047C", Offset = "0x1B3047C", VA = "0x7BBC33047C")]
		public List<HPConfigInfo> GetHPConfigList()
		{
			return null;
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E3")]
		[Address(RVA = "0x1B30484", Offset = "0x1B30484", VA = "0x7BBC330484")]
		public string GetHPTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E4")]
		[Address(RVA = "0x1B30564", Offset = "0x1B30564", VA = "0x7BBC330564")]
		public List<EPConfigInfo> GetEPConfigList()
		{
			return null;
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E5")]
		[Address(RVA = "0x1B3056C", Offset = "0x1B3056C", VA = "0x7BBC33056C")]
		public string GetEPTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E6")]
		[Address(RVA = "0x1B3064C", Offset = "0x1B3064C", VA = "0x7BBC33064C")]
		public List<SpeedConfigInfo> GetSpeedConfigList()
		{
			return null;
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E7")]
		[Address(RVA = "0x1B30654", Offset = "0x1B30654", VA = "0x7BBC330654")]
		public string GetSpeedTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E8")]
		[Address(RVA = "0x1B30734", Offset = "0x1B30734", VA = "0x7BBC330734")]
		public List<JumpHeightConfigInfo> GetJumpHeightConfigList()
		{
			return null;
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1E9")]
		[Address(RVA = "0x1B3073C", Offset = "0x1B3073C", VA = "0x7BBC33073C")]
		public string GetJumpHeightTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1EA")]
		[Address(RVA = "0x1B3081C", Offset = "0x1B3081C", VA = "0x7BBC33081C")]
		public List<RoundNumConfigInfo> GetRoundNumConfigList()
		{
			return null;
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1EB")]
		[Address(RVA = "0x1B30824", Offset = "0x1B30824", VA = "0x7BBC330824")]
		public string GetRoundNumTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1EC")]
		[Address(RVA = "0x1B30904", Offset = "0x1B30904", VA = "0x7BBC330904")]
		public List<InitCoinConfigInfo> GetInitCoinConfigList()
		{
			return null;
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1ED")]
		[Address(RVA = "0x1B3090C", Offset = "0x1B3090C", VA = "0x7BBC33090C")]
		public string GetInitCoinTxtByKey(uint key)
		{
			return null;
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1EE")]
		[Address(RVA = "0x1B309EC", Offset = "0x1B309EC", VA = "0x7BBC3309EC")]
		public List<DropListConfigInfo> GetDropListConfigList(uint configID)
		{
			return null;
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1EF")]
		[Address(RVA = "0x1B30B70", Offset = "0x1B30B70", VA = "0x7BBC330B70")]
		public string GetDropListTxtById(uint id, uint configID)
		{
			return null;
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x0002A810 File Offset: 0x00028A10
		[Token(Token = "0x600A1F0")]
		[Address(RVA = "0x1B30CFC", Offset = "0x1B30CFC", VA = "0x7BBC330CFC")]
		public bool IsRoomCreateRulesInited()
		{
			return default(bool);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1F1")]
		[Address(RVA = "0x1B30D04", Offset = "0x1B30D04", VA = "0x7BBC330D04")]
		public void ClearRoomCreateRules()
		{
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1F2")]
		[Address(RVA = "0x1B30D0C", Offset = "0x1B30D0C", VA = "0x7BBC330D0C")]
		public void UpdateRoomCreateRules(List<RoomCreateRuleDesc> list)
		{
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1F3")]
		[Address(RVA = "0x1B3140C", Offset = "0x1B3140C", VA = "0x7BBC33140C")]
		public RoomCreateRuleDataManager()
		{
		}

		// Token: 0x0400A844 RID: 43076
		[Token(Token = "0x400A844")]
		[FieldOffset(Offset = "0x0")]
		public static uint INVALIAD_MAPCONFIGID;

		// Token: 0x0400A845 RID: 43077
		[Token(Token = "0x400A845")]
		[FieldOffset(Offset = "0x4")]
		public static uint CSSHOP_WEAPON_TYPETAB;

		// Token: 0x0400A846 RID: 43078
		[Token(Token = "0x400A846")]
		[FieldOffset(Offset = "0x8")]
		public static uint CSSHOP_ITEM_TYPETAB;

		// Token: 0x0400A847 RID: 43079
		[Token(Token = "0x400A847")]
		[FieldOffset(Offset = "0x12")]
		private bool m_IsRoomCreateRuleDropInited;

		// Token: 0x0400A848 RID: 43080
		[Token(Token = "0x400A848")]
		[FieldOffset(Offset = "0x13")]
		private bool m_IsRoomCreateRulesInited;

		// Token: 0x0400A849 RID: 43081
		[Token(Token = "0x400A849")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, RoomCreateRuleDataManager.MapConfigInfo> m_MapConfigGroupDic;

		// Token: 0x0400A84A RID: 43082
		[Token(Token = "0x400A84A")]
		[FieldOffset(Offset = "0x20")]
		private List<HPConfigInfo> m_HPConfigList;

		// Token: 0x0400A84B RID: 43083
		[Token(Token = "0x400A84B")]
		[FieldOffset(Offset = "0x28")]
		private List<EPConfigInfo> m_EPConfigList;

		// Token: 0x0400A84C RID: 43084
		[Token(Token = "0x400A84C")]
		[FieldOffset(Offset = "0x30")]
		private List<SpeedConfigInfo> m_SpeedConfigList;

		// Token: 0x0400A84D RID: 43085
		[Token(Token = "0x400A84D")]
		[FieldOffset(Offset = "0x38")]
		private List<JumpHeightConfigInfo> m_JumpHeightConfigList;

		// Token: 0x0400A84E RID: 43086
		[Token(Token = "0x400A84E")]
		[FieldOffset(Offset = "0x40")]
		private List<DropListConfigInfo> m_DropListConfigList;

		// Token: 0x0400A84F RID: 43087
		[Token(Token = "0x400A84F")]
		[FieldOffset(Offset = "0x48")]
		private List<DropListConfigInfo> m_DropListConfigListCS;

		// Token: 0x0400A850 RID: 43088
		[Token(Token = "0x400A850")]
		[FieldOffset(Offset = "0x50")]
		private List<RoundNumConfigInfo> m_RoundNumConfigList;

		// Token: 0x0400A851 RID: 43089
		[Token(Token = "0x400A851")]
		[FieldOffset(Offset = "0x58")]
		private List<InitCoinConfigInfo> m_InitCoinConfigList;

		// Token: 0x0400A852 RID: 43090
		[Token(Token = "0x400A852")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, List<RoomCreateCSShopData>> m_CreateRoomCSShopWeaponDic;

		// Token: 0x0400A853 RID: 43091
		[Token(Token = "0x400A853")]
		[FieldOffset(Offset = "0x68")]
		private List<RoomCreateCSShopData> m_CreateRoomCSShopWeaponList;

		// Token: 0x0400A854 RID: 43092
		[Token(Token = "0x400A854")]
		[FieldOffset(Offset = "0x70")]
		private List<RoomCreateCSShopData> m_CreateRoomCSShopItemList;

		// Token: 0x0400A855 RID: 43093
		[Token(Token = "0x400A855")]
		[FieldOffset(Offset = "0x78")]
		private List<uint> m_CSShopTypeTabList;

		// Token: 0x0400A856 RID: 43094
		[Token(Token = "0x400A856")]
		[FieldOffset(Offset = "0x80")]
		private List<RoomCreateCSEcoData> m_CreateRoomCSEcoList;

		// Token: 0x0400A857 RID: 43095
		[Token(Token = "0x400A857")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<uint, List<uint>> m_MapConfigIdDic;

		// Token: 0x0400A858 RID: 43096
		[Token(Token = "0x400A858")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<uint, Dictionary<uint, List<uint>>> m_ModeMapIdDic;

		// Token: 0x0400A859 RID: 43097
		[Token(Token = "0x400A859")]
		[FieldOffset(Offset = "0x98")]
		private List<uint> m_GameModeIdList;

		// Token: 0x02001D07 RID: 7431
		[Token(Token = "0x2001D07")]
		private enum EConfigType
		{
			// Token: 0x0400A85B RID: 43099
			[Token(Token = "0x400A85B")]
			EConfigType_HP,
			// Token: 0x0400A85C RID: 43100
			[Token(Token = "0x400A85C")]
			EConfigType_EP,
			// Token: 0x0400A85D RID: 43101
			[Token(Token = "0x400A85D")]
			EConfigType_Speed,
			// Token: 0x0400A85E RID: 43102
			[Token(Token = "0x400A85E")]
			EConfigType_JumpHeight,
			// Token: 0x0400A85F RID: 43103
			[Token(Token = "0x400A85F")]
			EConfigType_RoundNum,
			// Token: 0x0400A860 RID: 43104
			[Token(Token = "0x400A860")]
			EConfigType_InitCoin
		}

		// Token: 0x02001D08 RID: 7432
		[Token(Token = "0x2001D08")]
		private struct MapConfigInfo
		{
			// Token: 0x0400A861 RID: 43105
			[Token(Token = "0x400A861")]
			[FieldOffset(Offset = "0x0")]
			public uint[] members;

			// Token: 0x0400A862 RID: 43106
			[Token(Token = "0x400A862")]
			[FieldOffset(Offset = "0x8")]
			public uint[] spectators;

			// Token: 0x0400A863 RID: 43107
			[Token(Token = "0x400A863")]
			[FieldOffset(Offset = "0x10")]
			public uint minMemberCnt;
		}

		// Token: 0x02001D09 RID: 7433
		[Token(Token = "0x2001D09")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAB4", Offset = "0x10FBAB4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A1F6 RID: 41462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1F6")]
			[Address(RVA = "0x1B317B4", Offset = "0x1B317B4", VA = "0x7BBC3317B4")]
			public <>c()
			{
			}

			// Token: 0x0600A1F7 RID: 41463 RVA: 0x0002A828 File Offset: 0x00028A28
			[Token(Token = "0x600A1F7")]
			[Address(RVA = "0x1B317BC", Offset = "0x1B317BC", VA = "0x7BBC3317BC")]
			internal int <UpdateRoomCreateRuleDrop>b__36_0(DropListConfigInfo a, DropListConfigInfo b)
			{
				return 0;
			}

			// Token: 0x0600A1F8 RID: 41464 RVA: 0x0002A840 File Offset: 0x00028A40
			[Token(Token = "0x600A1F8")]
			[Address(RVA = "0x1B317D0", Offset = "0x1B317D0", VA = "0x7BBC3317D0")]
			internal int <UpdateRoomCreateRuleDrop>b__36_1(DropListConfigInfo a, DropListConfigInfo b)
			{
				return 0;
			}

			// Token: 0x0400A864 RID: 43108
			[Token(Token = "0x400A864")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RoomCreateRuleDataManager.<>c <>9;

			// Token: 0x0400A865 RID: 43109
			[Token(Token = "0x400A865")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<DropListConfigInfo> <>9__36_0;

			// Token: 0x0400A866 RID: 43110
			[Token(Token = "0x400A866")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<DropListConfigInfo> <>9__36_1;
		}

		// Token: 0x02001D0A RID: 7434
		[Token(Token = "0x2001D0A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAC4", Offset = "0x10FBAC4")]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x0600A1F9 RID: 41465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1F9")]
			[Address(RVA = "0x1B3055C", Offset = "0x1B3055C", VA = "0x7BBC33055C")]
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x0600A1FA RID: 41466 RVA: 0x0002A858 File Offset: 0x00028A58
			[Token(Token = "0x600A1FA")]
			[Address(RVA = "0x1B317E4", Offset = "0x1B317E4", VA = "0x7BBC3317E4")]
			internal bool <GetHPTxtByKey>b__0(HPConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A867 RID: 43111
			[Token(Token = "0x400A867")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D0B RID: 7435
		[Token(Token = "0x2001D0B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAD4", Offset = "0x10FBAD4")]
		private sealed class <>c__DisplayClass48_0
		{
			// Token: 0x0600A1FB RID: 41467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1FB")]
			[Address(RVA = "0x1B30644", Offset = "0x1B30644", VA = "0x7BBC330644")]
			public <>c__DisplayClass48_0()
			{
			}

			// Token: 0x0600A1FC RID: 41468 RVA: 0x0002A870 File Offset: 0x00028A70
			[Token(Token = "0x600A1FC")]
			[Address(RVA = "0x1B317F4", Offset = "0x1B317F4", VA = "0x7BBC3317F4")]
			internal bool <GetEPTxtByKey>b__0(EPConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A868 RID: 43112
			[Token(Token = "0x400A868")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D0C RID: 7436
		[Token(Token = "0x2001D0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAE4", Offset = "0x10FBAE4")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600A1FD RID: 41469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1FD")]
			[Address(RVA = "0x1B3072C", Offset = "0x1B3072C", VA = "0x7BBC33072C")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600A1FE RID: 41470 RVA: 0x0002A888 File Offset: 0x00028A88
			[Token(Token = "0x600A1FE")]
			[Address(RVA = "0x1B31804", Offset = "0x1B31804", VA = "0x7BBC331804")]
			internal bool <GetSpeedTxtByKey>b__0(SpeedConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A869 RID: 43113
			[Token(Token = "0x400A869")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D0D RID: 7437
		[Token(Token = "0x2001D0D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBAF4", Offset = "0x10FBAF4")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x0600A1FF RID: 41471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1FF")]
			[Address(RVA = "0x1B30814", Offset = "0x1B30814", VA = "0x7BBC330814")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x0600A200 RID: 41472 RVA: 0x0002A8A0 File Offset: 0x00028AA0
			[Token(Token = "0x600A200")]
			[Address(RVA = "0x1B31814", Offset = "0x1B31814", VA = "0x7BBC331814")]
			internal bool <GetJumpHeightTxtByKey>b__0(JumpHeightConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A86A RID: 43114
			[Token(Token = "0x400A86A")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D0E RID: 7438
		[Token(Token = "0x2001D0E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB04", Offset = "0x10FBB04")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x0600A201 RID: 41473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A201")]
			[Address(RVA = "0x1B308FC", Offset = "0x1B308FC", VA = "0x7BBC3308FC")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x0600A202 RID: 41474 RVA: 0x0002A8B8 File Offset: 0x00028AB8
			[Token(Token = "0x600A202")]
			[Address(RVA = "0x1B31824", Offset = "0x1B31824", VA = "0x7BBC331824")]
			internal bool <GetRoundNumTxtByKey>b__0(RoundNumConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A86B RID: 43115
			[Token(Token = "0x400A86B")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D0F RID: 7439
		[Token(Token = "0x2001D0F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB14", Offset = "0x10FBB14")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x0600A203 RID: 41475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A203")]
			[Address(RVA = "0x1B309E4", Offset = "0x1B309E4", VA = "0x7BBC3309E4")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x0600A204 RID: 41476 RVA: 0x0002A8D0 File Offset: 0x00028AD0
			[Token(Token = "0x600A204")]
			[Address(RVA = "0x1B31834", Offset = "0x1B31834", VA = "0x7BBC331834")]
			internal bool <GetInitCoinTxtByKey>b__0(InitCoinConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A86C RID: 43116
			[Token(Token = "0x400A86C")]
			[FieldOffset(Offset = "0x10")]
			public uint key;
		}

		// Token: 0x02001D10 RID: 7440
		[Token(Token = "0x2001D10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB24", Offset = "0x10FBB24")]
		private sealed class <>c__DisplayClass58_0
		{
			// Token: 0x0600A205 RID: 41477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A205")]
			[Address(RVA = "0x1B30CF4", Offset = "0x1B30CF4", VA = "0x7BBC330CF4")]
			public <>c__DisplayClass58_0()
			{
			}

			// Token: 0x0600A206 RID: 41478 RVA: 0x0002A8E8 File Offset: 0x00028AE8
			[Token(Token = "0x600A206")]
			[Address(RVA = "0x1B31844", Offset = "0x1B31844", VA = "0x7BBC331844")]
			internal bool <GetDropListTxtById>b__0(DropListConfigInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A86D RID: 43117
			[Token(Token = "0x400A86D")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}
	}
}
