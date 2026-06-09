using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001F5D RID: 8029
	[Token(Token = "0x2001F5D")]
	public class UIModelMapOpeningInfo : UIBaseModel, IUIModelDataChangeObserver
	{
		// Token: 0x0600B0A4 RID: 45220 RVA: 0x00031668 File Offset: 0x0002F868
		[Token(Token = "0x600B0A4")]
		[Address(RVA = "0x1509714", Offset = "0x1509714", VA = "0x7BBBD09714")]
		public bool IsWinnerModeEntranceFree()
		{
			return default(bool);
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x00031680 File Offset: 0x0002F880
		// (set) Token: 0x0600B0A6 RID: 45222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBB")]
		public int WinnerModeChipCost
		{
			[Token(Token = "0x600B0A5")]
			[Address(RVA = "0x150971C", Offset = "0x150971C", VA = "0x7BBBD0971C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467BC", Offset = "0x11467BC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B0A6")]
			[Address(RVA = "0x1509724", Offset = "0x1509724", VA = "0x7BBBD09724")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467CC", Offset = "0x11467CC")]
			private set
			{
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x00031698 File Offset: 0x0002F898
		// (set) Token: 0x0600B0A8 RID: 45224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBC")]
		public int WinnerModeDiamondeCost
		{
			[Token(Token = "0x600B0A7")]
			[Address(RVA = "0x150972C", Offset = "0x150972C", VA = "0x7BBBD0972C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467DC", Offset = "0x11467DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B0A8")]
			[Address(RVA = "0x1509734", Offset = "0x1509734", VA = "0x7BBBD09734")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467EC", Offset = "0x11467EC")]
			private set
			{
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x000316B0 File Offset: 0x0002F8B0
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBD")]
		public int WinnerModeCurrencyType
		{
			[Token(Token = "0x600B0A9")]
			[Address(RVA = "0x150973C", Offset = "0x150973C", VA = "0x7BBBD0973C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11467FC", Offset = "0x11467FC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600B0AA")]
			[Address(RVA = "0x1509744", Offset = "0x1509744", VA = "0x7BBBD09744")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114680C", Offset = "0x114680C")]
			set
			{
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600B0AB RID: 45227 RVA: 0x000316C8 File Offset: 0x0002F8C8
		[Token(Token = "0x17000BBE")]
		public DateTime RegionServerTime
		{
			[Token(Token = "0x600B0AB")]
			[Address(RVA = "0x150974C", Offset = "0x150974C", VA = "0x7BBBD0974C")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x000316E0 File Offset: 0x0002F8E0
		[Token(Token = "0x600B0AC")]
		[Address(RVA = "0x15097F8", Offset = "0x15097F8", VA = "0x7BBBD097F8")]
		public static uint MakeOpeningInfoID(uint matchMode, uint mapID, uint gameMode)
		{
			return 0U;
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600B0AD RID: 45229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBF")]
		public List<MapOpeningInfo> TotalOpeningInfoList
		{
			[Token(Token = "0x600B0AD")]
			[Address(RVA = "0x150982C", Offset = "0x150982C", VA = "0x7BBBD0982C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600B0AE RID: 45230 RVA: 0x000316F8 File Offset: 0x0002F8F8
		// (set) Token: 0x0600B0AF RID: 45231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BC0")]
		public float OneMapRP
		{
			[Token(Token = "0x600B0AE")]
			[Address(RVA = "0x1509834", Offset = "0x1509834", VA = "0x7BBBD09834")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114681C", Offset = "0x114681C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600B0AF")]
			[Address(RVA = "0x150983C", Offset = "0x150983C", VA = "0x7BBBD0983C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114682C", Offset = "0x114682C")]
			private set
			{
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x00031710 File Offset: 0x0002F910
		// (set) Token: 0x0600B0B1 RID: 45233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BC1")]
		public float TwoMapRP
		{
			[Token(Token = "0x600B0B0")]
			[Address(RVA = "0x1509844", Offset = "0x1509844", VA = "0x7BBBD09844")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114683C", Offset = "0x114683C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600B0B1")]
			[Address(RVA = "0x150984C", Offset = "0x150984C", VA = "0x7BBBD0984C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114684C", Offset = "0x114684C")]
			private set
			{
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x00031728 File Offset: 0x0002F928
		// (set) Token: 0x0600B0B3 RID: 45235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BC2")]
		public float ThreeMapRP
		{
			[Token(Token = "0x600B0B2")]
			[Address(RVA = "0x1509854", Offset = "0x1509854", VA = "0x7BBBD09854")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114685C", Offset = "0x114685C")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600B0B3")]
			[Address(RVA = "0x150985C", Offset = "0x150985C", VA = "0x7BBBD0985C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114686C", Offset = "0x114686C")]
			private set
			{
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC3")]
		public List<MapModeData> MapModeList
		{
			[Token(Token = "0x600B0B4")]
			[Address(RVA = "0x1509864", Offset = "0x1509864", VA = "0x7BBBD09864")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0B5")]
		[Address(RVA = "0x150986C", Offset = "0x150986C", VA = "0x7BBBD0986C")]
		public SortedDictionary<uint, List<MapModeData>> SortedMapModeDict()
		{
			return null;
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC4")]
		public List<MapOpeningInfo> NewOpeningInfoList
		{
			[Token(Token = "0x600B0B6")]
			[Address(RVA = "0x1509874", Offset = "0x1509874", VA = "0x7BBBD09874")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B0B7 RID: 45239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0B7")]
		[Address(RVA = "0x150987C", Offset = "0x150987C", VA = "0x7BBBD0987C")]
		public List<UIModelMapOpeningInfo.GameModeSortData> SortedGameModeDataList()
		{
			return null;
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC5")]
		public List<MapOpeningInfo> PermanentMapInfoList
		{
			[Token(Token = "0x600B0B8")]
			[Address(RVA = "0x1509AE0", Offset = "0x1509AE0", VA = "0x7BBBD09AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC6")]
		public List<MapOpeningInfo> HintMapInfoList
		{
			[Token(Token = "0x600B0B9")]
			[Address(RVA = "0x1509AE8", Offset = "0x1509AE8", VA = "0x7BBBD09AE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600B0BA RID: 45242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC7")]
		public List<MapModeData> TrainingMapInfoList
		{
			[Token(Token = "0x600B0BA")]
			[Address(RVA = "0x1509AF0", Offset = "0x1509AF0", VA = "0x7BBBD09AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0BB")]
		[Address(RVA = "0x1509AF8", Offset = "0x1509AF8", VA = "0x7BBBD09AF8")]
		public MapModeData SelectedMapData()
		{
			return null;
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x00031740 File Offset: 0x0002F940
		// (set) Token: 0x0600B0BC RID: 45244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BC8")]
		public bool IsRequestPending
		{
			[Token(Token = "0x600B0BD")]
			[Address(RVA = "0x1509CA8", Offset = "0x1509CA8", VA = "0x7BBBD09CA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114688C", Offset = "0x114688C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B0BC")]
			[Address(RVA = "0x1509C9C", Offset = "0x1509C9C", VA = "0x7BBBD09C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114687C", Offset = "0x114687C")]
			private set
			{
			}
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x00031758 File Offset: 0x0002F958
		[Token(Token = "0x600B0BE")]
		[Address(RVA = "0x1509CB0", Offset = "0x1509CB0", VA = "0x7BBBD09CB0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0BF")]
		[Address(RVA = "0x1509CB8", Offset = "0x1509CB8", VA = "0x7BBBD09CB8", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C0")]
		[Address(RVA = "0x1509D6C", Offset = "0x1509D6C", VA = "0x7BBBD09D6C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C1")]
		[Address(RVA = "0x1509E48", Offset = "0x1509E48", VA = "0x7BBBD09E48", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C2")]
		[Address(RVA = "0x1509ED8", Offset = "0x1509ED8", VA = "0x7BBBD09ED8", Slot = "11")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C3")]
		[Address(RVA = "0x1509FA8", Offset = "0x1509FA8", VA = "0x7BBBD09FA8")]
		public void RequestMapOpeningInfo()
		{
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C4")]
		[Address(RVA = "0x150A15C", Offset = "0x150A15C", VA = "0x7BBBD0A15C")]
		public void UpdateMapOpeningInfo(GameOpeningInfoRes data)
		{
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0C5")]
		[Address(RVA = "0x150B604", Offset = "0x150B604", VA = "0x7BBBD0B604")]
		private RankingLevelLimitDesc GetLevelLimitDesc(l}BQs\u0080\u0082 tarGameMode, f tarMatchMode)
		{
			return null;
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0C6")]
		[Address(RVA = "0x150B75C", Offset = "0x150B75C", VA = "0x7BBBD0B75C")]
		private void ResetLevelEntranceUnlockData()
		{
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x00031770 File Offset: 0x0002F970
		[Token(Token = "0x600B0C7")]
		[Address(RVA = "0x150B888", Offset = "0x150B888", VA = "0x7BBBD0B888")]
		public int GetMatchGuestUnlockLevel(l}BQs\u0080\u0082 gameMode, f matchMode)
		{
			return 0;
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x00031788 File Offset: 0x0002F988
		[Token(Token = "0x600B0C8")]
		[Address(RVA = "0x150B8A4", Offset = "0x150B8A4", VA = "0x7BBBD0B8A4")]
		public int GetMatchNormalUnlockLevel(l}BQs\u0080\u0082 gameMode, f matchMode)
		{
			return 0;
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x000317A0 File Offset: 0x0002F9A0
		[Token(Token = "0x600B0C9")]
		[Address(RVA = "0x150B8C0", Offset = "0x150B8C0", VA = "0x7BBBD0B8C0")]
		public bool CheckLevelSatisfy(l}BQs\u0080\u0082 gameMode, f matchMode, bool showTips = false)
		{
			return default(bool);
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x000317B8 File Offset: 0x0002F9B8
		[Token(Token = "0x600B0CA")]
		[Address(RVA = "0x150BCD8", Offset = "0x150BCD8", VA = "0x7BBBD0BCD8")]
		public bool CheckMapMode(MapModeData mapData, bool showTips = true)
		{
			return default(bool);
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x000317D0 File Offset: 0x0002F9D0
		[Token(Token = "0x600B0CB")]
		[Address(RVA = "0x150D088", Offset = "0x150D088", VA = "0x7BBBD0D088")]
		public int GetGuestRegisterNeedTime(l}BQs\u0080\u0082 gameMode, f matchMode)
		{
			return 0;
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x000317E8 File Offset: 0x0002F9E8
		[Token(Token = "0x600B0CC")]
		[Address(RVA = "0x150D0A4", Offset = "0x150D0A4", VA = "0x7BBBD0D0A4")]
		public int GetNormalRegisterNeedTime(l}BQs\u0080\u0082 gameMode, f matchMode)
		{
			return 0;
		}

		// Token: 0x0600B0CD RID: 45261 RVA: 0x00031800 File Offset: 0x0002FA00
		[Token(Token = "0x600B0CD")]
		[Address(RVA = "0x150C97C", Offset = "0x150C97C", VA = "0x7BBBD0C97C")]
		public bool CheckRegisterTimeSatisfy(l}BQs\u0080\u0082 gameMode, f matchMode, bool showTips)
		{
			return default(bool);
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0CE")]
		[Address(RVA = "0x150B398", Offset = "0x150B398", VA = "0x7BBBD0B398")]
		private void SaveModeOfRandomMap(MapOpeningInfo mapOpening)
		{
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0CF")]
		[Address(RVA = "0x150D0C0", Offset = "0x150D0C0", VA = "0x7BBBD0D0C0")]
		public uint[] GetRandomMapIds(uint gameMode, uint matchMode)
		{
			return null;
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x00031818 File Offset: 0x0002FA18
		[Token(Token = "0x600B0D0")]
		[Address(RVA = "0x150D428", Offset = "0x150D428", VA = "0x7BBBD0D428")]
		public bool IsInMapOpeingPeriod(MapOpeningInfo mapInfo)
		{
			return default(bool);
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x00031830 File Offset: 0x0002FA30
		[Token(Token = "0x600B0D1")]
		[Address(RVA = "0x150CDC4", Offset = "0x150CDC4", VA = "0x7BBBD0CDC4")]
		public bool IsMapOpening(uint map_id, uint game_mode, uint match_mode)
		{
			return default(bool);
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x00031848 File Offset: 0x0002FA48
		[Token(Token = "0x600B0D2")]
		[Address(RVA = "0x150D70C", Offset = "0x150D70C", VA = "0x7BBBD0D70C")]
		public bool IsGameModeOpening(uint game_mode)
		{
			return default(bool);
		}

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0D3")]
		[Address(RVA = "0x150D7D4", Offset = "0x150D7D4", VA = "0x7BBBD0D7D4")]
		public MapOpeningInfo GetOpeningMapByGameMode(uint gameMode)
		{
			return null;
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0D4")]
		[Address(RVA = "0x150D978", Offset = "0x150D978", VA = "0x7BBBD0D978")]
		public List<MapModeData> GetMapModeListByGameMode(uint gameMode, uint matchMode)
		{
			return null;
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0D5")]
		[Address(RVA = "0x150DB64", Offset = "0x150DB64", VA = "0x7BBBD0DB64")]
		public uint[] GetPlayersLimits(uint map_id, uint game_mode, uint match_mode)
		{
			return null;
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x00031860 File Offset: 0x0002FA60
		[Token(Token = "0x600B0D6")]
		[Address(RVA = "0x150D518", Offset = "0x150D518", VA = "0x7BBBD0D518")]
		public bool CheckMapIsOpening(MapOpeningInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x00031878 File Offset: 0x0002FA78
		[Token(Token = "0x600B0D7")]
		[Address(RVA = "0x150DCF8", Offset = "0x150DCF8", VA = "0x7BBBD0DCF8")]
		public bool CheckMapIsOpeningInToday(MapOpeningInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x00031890 File Offset: 0x0002FA90
		[Token(Token = "0x600B0D8")]
		[Address(RVA = "0x150DE08", Offset = "0x150DE08", VA = "0x7BBBD0DE08")]
		public int GetMapOpeningLeftTime(MapOpeningInfo info)
		{
			return 0;
		}

		// Token: 0x0600B0D9 RID: 45273 RVA: 0x000318A8 File Offset: 0x0002FAA8
		[Token(Token = "0x600B0D9")]
		[Address(RVA = "0x150DF38", Offset = "0x150DF38", VA = "0x7BBBD0DF38")]
		public int GetNextMapOpenTime(MapOpeningInfo info)
		{
			return 0;
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DA")]
		[Address(RVA = "0x150E174", Offset = "0x150E174", VA = "0x7BBBD0E174")]
		public MapOpeningInfo GetNewOpeningMapInfo()
		{
			return null;
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DB")]
		[Address(RVA = "0x150E2CC", Offset = "0x150E2CC", VA = "0x7BBBD0E2CC")]
		public string GetMatchModeString(uint matchMode)
		{
			return null;
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DC")]
		[Address(RVA = "0x150E4E8", Offset = "0x150E4E8", VA = "0x7BBBD0E4E8")]
		public string GetGameModeString(uint gMode)
		{
			return null;
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DD")]
		[Address(RVA = "0x150E4F4", Offset = "0x150E4F4", VA = "0x7BBBD0E4F4")]
		public string GetGameModeStringLobbyOnly(uint gMode)
		{
			return null;
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DE")]
		[Address(RVA = "0x150E5B0", Offset = "0x150E5B0", VA = "0x7BBBD0E5B0")]
		public string GetMapModeString(uint mapMode)
		{
			return null;
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0DF")]
		[Address(RVA = "0x150E5BC", Offset = "0x150E5BC", VA = "0x7BBBD0E5BC")]
		public string GetMapBgSpriteName(MapModeData data)
		{
			return null;
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0E0")]
		[Address(RVA = "0x150E6BC", Offset = "0x150E6BC", VA = "0x7BBBD0E6BC")]
		public void SetDefaultMap()
		{
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0E1")]
		[Address(RVA = "0x1509B28", Offset = "0x1509B28", VA = "0x7BBBD09B28")]
		public MapModeData GetDefaultMap()
		{
			return null;
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0E2")]
		[Address(RVA = "0x150E734", Offset = "0x150E734", VA = "0x7BBBD0E734")]
		public void UpdateSelectedMapData(uint matchMode, uint gameMode, uint mapMode)
		{
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0E3")]
		[Address(RVA = "0x150B520", Offset = "0x150B520", VA = "0x7BBBD0B520")]
		private void UpdateLevelVisualStyle()
		{
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x000318C0 File Offset: 0x0002FAC0
		[Token(Token = "0x600B0E4")]
		[Address(RVA = "0x150E8D4", Offset = "0x150E8D4", VA = "0x7BBBD0E8D4")]
		public bool IsMapLimitedOpen(MapModeData data)
		{
			return default(bool);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0E5")]
		[Address(RVA = "0x150CFB8", Offset = "0x150CFB8", VA = "0x7BBBD0CFB8")]
		public MapOpeningInfo GetOpeningInfo(MapModeData data)
		{
			return null;
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0E6")]
		[Address(RVA = "0x150EA40", Offset = "0x150EA40", VA = "0x7BBBD0EA40")]
		public MapOpeningInfo GetChampionshipMapByType(uint championshipType)
		{
			return null;
		}

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x000318D8 File Offset: 0x0002FAD8
		[Token(Token = "0x600B0E7")]
		[Address(RVA = "0x150B35C", Offset = "0x150B35C", VA = "0x7BBBD0B35C")]
		public bool IsChampionshipMode(uint match_mode)
		{
			return default(bool);
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x000318F0 File Offset: 0x0002FAF0
		[Token(Token = "0x600B0E8")]
		[Address(RVA = "0x150B368", Offset = "0x150B368", VA = "0x7BBBD0B368")]
		public bool IsTrainingMode(MapOpeningInfo map_info)
		{
			return default(bool);
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x00031908 File Offset: 0x0002FB08
		[Token(Token = "0x600B0E9")]
		[Address(RVA = "0x150ED98", Offset = "0x150ED98", VA = "0x7BBBD0ED98")]
		public static bool IsRankingMatchMode(uint match_mode)
		{
			return default(bool);
		}

		// Token: 0x0600B0EA RID: 45290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0EA")]
		[Address(RVA = "0x150EDA8", Offset = "0x150EDA8", VA = "0x7BBBD0EDA8")]
		public MapModeData GetMapModeData(uint matchMode, uint gameMode, uint mapMode)
		{
			return null;
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0EB")]
		[Address(RVA = "0x150EEB4", Offset = "0x150EEB4", VA = "0x7BBBD0EEB4")]
		public MapModeData GetPVEMapModeDataByConfigID(uint confId)
		{
			return null;
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0EC")]
		[Address(RVA = "0x150EF08", Offset = "0x150EF08", VA = "0x7BBBD0EF08")]
		public void SetCachedPVEMapDifficulty(uint confId, EMapDifficulty difficulty)
		{
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0ED")]
		[Address(RVA = "0x150EF80", Offset = "0x150EF80", VA = "0x7BBBD0EF80")]
		public void SavePVEMapDifficulty()
		{
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x00031920 File Offset: 0x0002FB20
		[Token(Token = "0x600B0EE")]
		[Address(RVA = "0x150F130", Offset = "0x150F130", VA = "0x7BBBD0F130")]
		public int GetPVEMapDifficultyByConfigID(uint confId)
		{
			return 0;
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0EF")]
		[Address(RVA = "0x150F2AC", Offset = "0x150F2AC", VA = "0x7BBBD0F2AC")]
		public void SetCachedPVEMapID(MapModeData mapdata)
		{
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0F0")]
		[Address(RVA = "0x150F2E4", Offset = "0x150F2E4", VA = "0x7BBBD0F2E4")]
		public void SavePVEMapID()
		{
		}

		// Token: 0x0600B0F1 RID: 45297 RVA: 0x00031938 File Offset: 0x0002FB38
		[Token(Token = "0x600B0F1")]
		[Address(RVA = "0x150F368", Offset = "0x150F368", VA = "0x7BBBD0F368")]
		public int GetSavedPVEMapID()
		{
			return 0;
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x00031950 File Offset: 0x0002FB50
		[Token(Token = "0x600B0F2")]
		[Address(RVA = "0x150F3F4", Offset = "0x150F3F4", VA = "0x7BBBD0F3F4")]
		public bool CanChangePVEMap()
		{
			return default(bool);
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x00031968 File Offset: 0x0002FB68
		[Token(Token = "0x600B0F3")]
		[Address(RVA = "0x150F4AC", Offset = "0x150F4AC", VA = "0x7BBBD0F4AC")]
		public bool NeedShowMapHint()
		{
			return default(bool);
		}

		// Token: 0x0600B0F4 RID: 45300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0F4")]
		[Address(RVA = "0x150F608", Offset = "0x150F608", VA = "0x7BBBD0F608")]
		public void SetMapShowedFlag(bool is_showed)
		{
		}

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x00031980 File Offset: 0x0002FB80
		[Token(Token = "0x600B0F5")]
		[Address(RVA = "0x150F688", Offset = "0x150F688", VA = "0x7BBBD0F688")]
		public bool IsMapDataAvailable(bool retry)
		{
			return default(bool);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0F6")]
		[Address(RVA = "0x150F718", Offset = "0x150F718", VA = "0x7BBBD0F718")]
		public void GetWinnerTakesAllInfo()
		{
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0F7")]
		[Address(RVA = "0x150F938", Offset = "0x150F938", VA = "0x7BBBD0F938")]
		public string GetGameModeName(MapModeData data)
		{
			return null;
		}

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x00031998 File Offset: 0x0002FB98
		[Token(Token = "0x600B0F8")]
		[Address(RVA = "0x150F984", Offset = "0x150F984", VA = "0x7BBBD0F984")]
		public bool CheckAndRequestDownloadMapRes(uint map, uint mode, string message = "")
		{
			return default(bool);
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0F9")]
		[Address(RVA = "0x150FC1C", Offset = "0x150FC1C", VA = "0x7BBBD0FC1C")]
		public List<ResourceID> NeedDownloadMapRes(uint mapConfigID, bool includeMode = false, bool includeModeRes = true)
		{
			return null;
		}

		// Token: 0x0600B0FA RID: 45306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0FA")]
		[Address(RVA = "0x150FBE0", Offset = "0x150FBE0", VA = "0x7BBBD0FBE0")]
		public List<ResourceID> NeedDownloadMapRes(uint map, uint mode, bool includeMode = false, bool includeModeRes = true)
		{
			return null;
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B0FB")]
		[Address(RVA = "0x150FE78", Offset = "0x150FE78", VA = "0x7BBBD0FE78")]
		public uint[] GetAvailableMapIdArray()
		{
			return null;
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0FC")]
		[Address(RVA = "0x150FEF0", Offset = "0x150FEF0", VA = "0x7BBBD0FEF0")]
		public void RefreshAvailableMapIdArray()
		{
		}

		// Token: 0x0600B0FD RID: 45309 RVA: 0x000319B0 File Offset: 0x0002FBB0
		[Token(Token = "0x600B0FD")]
		[Address(RVA = "0x15104BC", Offset = "0x15104BC", VA = "0x7BBBD104BC")]
		public bool IsMapAvailable(uint mapID)
		{
			return default(bool);
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B0FE")]
		[Address(RVA = "0x1510544", Offset = "0x1510544", VA = "0x7BBBD10544", Slot = "14")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x000319C8 File Offset: 0x0002FBC8
		[Token(Token = "0x600B0FF")]
		[Address(RVA = "0x1510650", Offset = "0x1510650", VA = "0x7BBBD10650", Slot = "15")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x000319E0 File Offset: 0x0002FBE0
		[Token(Token = "0x600B100")]
		[Address(RVA = "0x1510694", Offset = "0x1510694", VA = "0x7BBBD10694")]
		public bool IsClassicMode(MapModeData data)
		{
			return default(bool);
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B101")]
		[Address(RVA = "0x15106DC", Offset = "0x15106DC", VA = "0x7BBBD106DC")]
		public void SetMapRP(RankingMatchParam data)
		{
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B102")]
		[Address(RVA = "0x151074C", Offset = "0x151074C", VA = "0x7BBBD1074C")]
		public UIModelMapOpeningInfo()
		{
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x000319F8 File Offset: 0x0002FBF8
		[Token(Token = "0x600B103")]
		[Address(RVA = "0x1510984", Offset = "0x1510984", VA = "0x7BBBD10984")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114689C", Offset = "0x114689C")]
		private bool <UpdateLevelVisualStyle>b__111_0(MapModeData a)
		{
			return default(bool);
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B104")]
		[Address(RVA = "0x1510A20", Offset = "0x1510A20", VA = "0x7BBBD10A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11468AC", Offset = "0x11468AC")]
		private void <GetWinnerTakesAllInfo>b__130_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B431 RID: 46129
		[Token(Token = "0x400B431")]
		[FieldOffset(Offset = "0x18")]
		private long RegionServerTimeOffset;

		// Token: 0x0400B432 RID: 46130
		[Token(Token = "0x400B432")]
		[FieldOffset(Offset = "0x20")]
		private ulong m_RefreshWinnerEntranceTimeAt;

		// Token: 0x0400B433 RID: 46131
		[Token(Token = "0x400B433")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsWinnerModeEntranceFree;

		// Token: 0x0400B434 RID: 46132
		[Token(Token = "0x400B434")]
		public const string RANK_GUIDE_KEY = "rank_guide";

		// Token: 0x0400B435 RID: 46133
		[Token(Token = "0x400B435")]
		[FieldOffset(Offset = "0x30")]
		private RankingLevelLimitDescList m_MatchLevelLimitDescList;

		// Token: 0x0400B436 RID: 46134
		[Token(Token = "0x400B436")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113017C", Offset = "0x113017C")]
		private int <WinnerModeChipCost>k__BackingField;

		// Token: 0x0400B437 RID: 46135
		[Token(Token = "0x400B437")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113018C", Offset = "0x113018C")]
		private int <WinnerModeDiamondeCost>k__BackingField;

		// Token: 0x0400B438 RID: 46136
		[Token(Token = "0x400B438")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113019C", Offset = "0x113019C")]
		private int <WinnerModeCurrencyType>k__BackingField;

		// Token: 0x0400B439 RID: 46137
		[Token(Token = "0x400B439")]
		[FieldOffset(Offset = "0x48")]
		private List<MapOpeningInfo> m_TotalOpeningInfoList;

		// Token: 0x0400B43A RID: 46138
		[Token(Token = "0x400B43A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301AC", Offset = "0x11301AC")]
		private float <OneMapRP>k__BackingField;

		// Token: 0x0400B43B RID: 46139
		[Token(Token = "0x400B43B")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301BC", Offset = "0x11301BC")]
		private float <TwoMapRP>k__BackingField;

		// Token: 0x0400B43C RID: 46140
		[Token(Token = "0x400B43C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301CC", Offset = "0x11301CC")]
		private float <ThreeMapRP>k__BackingField;

		// Token: 0x0400B43D RID: 46141
		[Token(Token = "0x400B43D")]
		[FieldOffset(Offset = "0x60")]
		private List<MapModeData> m_MapModeList;

		// Token: 0x0400B43E RID: 46142
		[Token(Token = "0x400B43E")]
		[FieldOffset(Offset = "0x68")]
		private SortedDictionary<uint, List<MapModeData>> m_SortedMapModeDict;

		// Token: 0x0400B43F RID: 46143
		[Token(Token = "0x400B43F")]
		[FieldOffset(Offset = "0x70")]
		private List<MapOpeningInfo> m_NewOpeningInfoList;

		// Token: 0x0400B440 RID: 46144
		[Token(Token = "0x400B440")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, List<MapModeData>> m_ModeDictOfRandomMap;

		// Token: 0x0400B441 RID: 46145
		[Token(Token = "0x400B441")]
		[FieldOffset(Offset = "0x80")]
		private List<UIModelMapOpeningInfo.GameModeSortData> m_SortedGameModeData;

		// Token: 0x0400B442 RID: 46146
		[Token(Token = "0x400B442")]
		[FieldOffset(Offset = "0x88")]
		private List<MapOpeningInfo> m_PermanentMapInfoList;

		// Token: 0x0400B443 RID: 46147
		[Token(Token = "0x400B443")]
		[FieldOffset(Offset = "0x90")]
		private List<MapOpeningInfo> m_HintMapInfoList;

		// Token: 0x0400B444 RID: 46148
		[Token(Token = "0x400B444")]
		[FieldOffset(Offset = "0x98")]
		private List<MapOpeningInfo> m_ChampionshipMapList;

		// Token: 0x0400B445 RID: 46149
		[Token(Token = "0x400B445")]
		[FieldOffset(Offset = "0xA0")]
		private List<MapModeData> m_TrainingMapList;

		// Token: 0x0400B446 RID: 46150
		[Token(Token = "0x400B446")]
		public const uint PropID_OpeningInfoListUpdate = 2U;

		// Token: 0x0400B447 RID: 46151
		[Token(Token = "0x400B447")]
		public const uint PropID_WinnerTakeAllInfoUpdate = 4U;

		// Token: 0x0400B448 RID: 46152
		[Token(Token = "0x400B448")]
		[FieldOffset(Offset = "0xA8")]
		private MapModeData m_SelectedMapData;

		// Token: 0x0400B449 RID: 46153
		[Token(Token = "0x400B449")]
		[FieldOffset(Offset = "0xB0")]
		public MapModeData CachedUISelectedMapData;

		// Token: 0x0400B44A RID: 46154
		[Token(Token = "0x400B44A")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<uint, EMapDifficulty> m_CachedMapDifficultyByConfId;

		// Token: 0x0400B44B RID: 46155
		[Token(Token = "0x400B44B")]
		[FieldOffset(Offset = "0xC0")]
		private int m_CachedPVEMapId;

		// Token: 0x0400B44C RID: 46156
		[Token(Token = "0x400B44C")]
		[FieldOffset(Offset = "0xC4")]
		public int DefaultPermanentMapIndex;

		// Token: 0x0400B44D RID: 46157
		[Token(Token = "0x400B44D")]
		[FieldOffset(Offset = "0xC8")]
		public bool m_HasAvailableMapsInited;

		// Token: 0x0400B44E RID: 46158
		[Token(Token = "0x400B44E")]
		private const string MAP_HINT_KEY = "map_hint";

		// Token: 0x0400B44F RID: 46159
		[Token(Token = "0x400B44F")]
		private const string MAP_PVE_KEY = "pve_map_id";

		// Token: 0x0400B450 RID: 46160
		[Token(Token = "0x400B450")]
		[FieldOffset(Offset = "0xC9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11301DC", Offset = "0x11301DC")]
		private bool <IsRequestPending>k__BackingField;

		// Token: 0x0400B451 RID: 46161
		[Token(Token = "0x400B451")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, string> m_GameModeNameDict;

		// Token: 0x0400B452 RID: 46162
		[Token(Token = "0x400B452")]
		[FieldOffset(Offset = "0xD8")]
		private List<uint> m_AvailableMapIdList;

		// Token: 0x02001F5E RID: 8030
		[Token(Token = "0x2001F5E")]
		public struct GameModeSortData
		{
			// Token: 0x0400B453 RID: 46163
			[Token(Token = "0x400B453")]
			[FieldOffset(Offset = "0x0")]
			public uint sort_id;

			// Token: 0x0400B454 RID: 46164
			[Token(Token = "0x400B454")]
			[FieldOffset(Offset = "0x8")]
			public List<MapModeData> mapmode_list;
		}

		// Token: 0x02001F5F RID: 8031
		[Token(Token = "0x2001F5F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1C4", Offset = "0x10FD1C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B106 RID: 45318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B106")]
			[Address(RVA = "0x1510BFC", Offset = "0x1510BFC", VA = "0x7BBBD10BFC")]
			public <>c()
			{
			}

			// Token: 0x0600B107 RID: 45319 RVA: 0x00031A10 File Offset: 0x0002FC10
			[Token(Token = "0x600B107")]
			[Address(RVA = "0x1510C04", Offset = "0x1510C04", VA = "0x7BBBD10C04")]
			internal int <UpdateMapOpeningInfo>b__80_0(UIModelMapOpeningInfo.GameModeSortData a, UIModelMapOpeningInfo.GameModeSortData b)
			{
				return 0;
			}

			// Token: 0x0600B108 RID: 45320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B108")]
			[Address(RVA = "0x1510C30", Offset = "0x1510C30", VA = "0x7BBBD10C30")]
			internal string <RefreshAvailableMapIdArray>b__137_0(uint i)
			{
				return null;
			}

			// Token: 0x0600B109 RID: 45321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B109")]
			[Address(RVA = "0x1510CA8", Offset = "0x1510CA8", VA = "0x7BBBD10CA8")]
			internal string <RefreshAvailableMapIdArray>b__137_1(string s1, string s2)
			{
				return null;
			}

			// Token: 0x0400B455 RID: 46165
			[Token(Token = "0x400B455")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMapOpeningInfo.<>c <>9;

			// Token: 0x0400B456 RID: 46166
			[Token(Token = "0x400B456")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<UIModelMapOpeningInfo.GameModeSortData> <>9__80_0;

			// Token: 0x0400B457 RID: 46167
			[Token(Token = "0x400B457")]
			[FieldOffset(Offset = "0x10")]
			public static Func<uint, string> <>9__137_0;

			// Token: 0x0400B458 RID: 46168
			[Token(Token = "0x400B458")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string, string, string> <>9__137_1;
		}

		// Token: 0x02001F60 RID: 8032
		[Token(Token = "0x2001F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1D4", Offset = "0x10FD1D4")]
		private sealed class <>c__DisplayClass110_0
		{
			// Token: 0x0600B10A RID: 45322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B10A")]
			[Address(RVA = "0x150E8CC", Offset = "0x150E8CC", VA = "0x7BBBD0E8CC")]
			public <>c__DisplayClass110_0()
			{
			}

			// Token: 0x0600B10B RID: 45323 RVA: 0x00031A28 File Offset: 0x0002FC28
			[Token(Token = "0x600B10B")]
			[Address(RVA = "0x1510D0C", Offset = "0x1510D0C", VA = "0x7BBBD10D0C")]
			internal bool <UpdateSelectedMapData>b__0(MapModeData a)
			{
				return default(bool);
			}

			// Token: 0x0600B10C RID: 45324 RVA: 0x00031A40 File Offset: 0x0002FC40
			[Token(Token = "0x600B10C")]
			[Address(RVA = "0x1510D70", Offset = "0x1510D70", VA = "0x7BBBD10D70")]
			internal bool <UpdateSelectedMapData>b__1(MapModeData a)
			{
				return default(bool);
			}

			// Token: 0x0400B459 RID: 46169
			[Token(Token = "0x400B459")]
			[FieldOffset(Offset = "0x10")]
			public uint matchMode;

			// Token: 0x0400B45A RID: 46170
			[Token(Token = "0x400B45A")]
			[FieldOffset(Offset = "0x14")]
			public uint gameMode;

			// Token: 0x0400B45B RID: 46171
			[Token(Token = "0x400B45B")]
			[FieldOffset(Offset = "0x18")]
			public uint mapMode;
		}

		// Token: 0x02001F61 RID: 8033
		[Token(Token = "0x2001F61")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1E4", Offset = "0x10FD1E4")]
		private sealed class <>c__DisplayClass112_0
		{
			// Token: 0x0600B10D RID: 45325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B10D")]
			[Address(RVA = "0x150EA30", Offset = "0x150EA30", VA = "0x7BBBD0EA30")]
			public <>c__DisplayClass112_0()
			{
			}

			// Token: 0x0600B10E RID: 45326 RVA: 0x00031A58 File Offset: 0x0002FC58
			[Token(Token = "0x600B10E")]
			[Address(RVA = "0x1510DD4", Offset = "0x1510DD4", VA = "0x7BBBD10DD4")]
			internal bool <IsMapLimitedOpen>b__0(MapOpeningInfo a)
			{
				return default(bool);
			}

			// Token: 0x0600B10F RID: 45327 RVA: 0x00031A70 File Offset: 0x0002FC70
			[Token(Token = "0x600B10F")]
			[Address(RVA = "0x1510E20", Offset = "0x1510E20", VA = "0x7BBBD10E20")]
			internal bool <IsMapLimitedOpen>b__1(MapOpeningInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B45C RID: 46172
			[Token(Token = "0x400B45C")]
			[FieldOffset(Offset = "0x10")]
			public MapModeData data;
		}

		// Token: 0x02001F62 RID: 8034
		[Token(Token = "0x2001F62")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD1F4", Offset = "0x10FD1F4")]
		private sealed class <>c__DisplayClass113_0
		{
			// Token: 0x0600B110 RID: 45328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B110")]
			[Address(RVA = "0x150EA38", Offset = "0x150EA38", VA = "0x7BBBD0EA38")]
			public <>c__DisplayClass113_0()
			{
			}

			// Token: 0x0600B111 RID: 45329 RVA: 0x00031A88 File Offset: 0x0002FC88
			[Token(Token = "0x600B111")]
			[Address(RVA = "0x1510E6C", Offset = "0x1510E6C", VA = "0x7BBBD10E6C")]
			internal bool <GetOpeningInfo>b__0(MapOpeningInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B45D RID: 46173
			[Token(Token = "0x400B45D")]
			[FieldOffset(Offset = "0x10")]
			public MapModeData data;
		}

		// Token: 0x02001F63 RID: 8035
		[Token(Token = "0x2001F63")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD204", Offset = "0x10FD204")]
		private sealed class <>c__DisplayClass118_0
		{
			// Token: 0x0600B112 RID: 45330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B112")]
			[Address(RVA = "0x150EEAC", Offset = "0x150EEAC", VA = "0x7BBBD0EEAC")]
			public <>c__DisplayClass118_0()
			{
			}

			// Token: 0x0600B113 RID: 45331 RVA: 0x00031AA0 File Offset: 0x0002FCA0
			[Token(Token = "0x600B113")]
			[Address(RVA = "0x1510EB8", Offset = "0x1510EB8", VA = "0x7BBBD10EB8")]
			internal bool <GetMapModeData>b__0(MapModeData a)
			{
				return default(bool);
			}

			// Token: 0x0400B45E RID: 46174
			[Token(Token = "0x400B45E")]
			[FieldOffset(Offset = "0x10")]
			public uint matchMode;

			// Token: 0x0400B45F RID: 46175
			[Token(Token = "0x400B45F")]
			[FieldOffset(Offset = "0x14")]
			public uint gameMode;

			// Token: 0x0400B460 RID: 46176
			[Token(Token = "0x400B460")]
			[FieldOffset(Offset = "0x18")]
			public uint mapMode;
		}
	}
}
