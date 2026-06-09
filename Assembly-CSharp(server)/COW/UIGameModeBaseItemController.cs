using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001840 RID: 6208
	[Token(Token = "0x2001840")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3A34", Offset = "0x10F3A34")]
	internal class UIGameModeBaseItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007987 RID: 31111 RVA: 0x000216C0 File Offset: 0x0001F8C0
		[Token(Token = "0x6007987")]
		[Address(RVA = "0x1FF9FE0", Offset = "0x1FF9FE0", VA = "0x7BBC7F9FE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007988")]
		[Address(RVA = "0x1FFA030", Offset = "0x1FFA030", VA = "0x7BBC7FA030")]
		public UIWidget GetWidget()
		{
			return null;
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007989")]
		[Address(RVA = "0x1FFA05C", Offset = "0x1FFA05C", VA = "0x7BBC7FA05C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798A")]
		[Address(RVA = "0x1FFA484", Offset = "0x1FFA484", VA = "0x7BBC7FA484", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798B")]
		[Address(RVA = "0x1FFA768", Offset = "0x1FFA768", VA = "0x7BBC7FA768")]
		public void SetUIData(uint matchMode, List<MapModeData> dataList, EGameModeUIType gameModeUiType)
		{
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798C")]
		[Address(RVA = "0x1FFAFA8", Offset = "0x1FFAFA8", VA = "0x7BBC7FAFA8")]
		private void updateDownloadList()
		{
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798D")]
		[Address(RVA = "0x1FFB1B8", Offset = "0x1FFB1B8", VA = "0x7BBC7FB1B8")]
		private void SetMapModeUI(MapModeData mapModeData)
		{
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600798E")]
		[Address(RVA = "0x1FFBA24", Offset = "0x1FFBA24", VA = "0x7BBC7FBA24")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11420C4", Offset = "0x11420C4")]
		public IEnumerator clipCDNTextureCoroutine()
		{
			return null;
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600798F")]
		[Address(RVA = "0x1FFBAC4", Offset = "0x1FFBAC4", VA = "0x7BBC7FBAC4")]
		private void ClipCDNTexture()
		{
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007990")]
		[Address(RVA = "0x1FFB9B0", Offset = "0x1FFB9B0", VA = "0x7BBC7FB9B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142128", Offset = "0x1142128")]
		private IEnumerator SetOpenDetailsUI()
		{
			return null;
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x000216D8 File Offset: 0x0001F8D8
		[Token(Token = "0x6007991")]
		[Address(RVA = "0x1FFB53C", Offset = "0x1FFB53C", VA = "0x7BBC7FB53C")]
		private bool LoadLiveEffects(MapModeData mapModeData)
		{
			return default(bool);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007992")]
		[Address(RVA = "0x1FFBEC4", Offset = "0x1FFBEC4", VA = "0x7BBC7FBEC4")]
		private void OnModeBtnClick()
		{
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x000216F0 File Offset: 0x0001F8F0
		[Token(Token = "0x6007993")]
		[Address(RVA = "0x1FFC3E4", Offset = "0x1FFC3E4", VA = "0x7BBC7FC3E4")]
		public int SortId()
		{
			return 0;
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007994")]
		[Address(RVA = "0x1FFC490", Offset = "0x1FFC490", VA = "0x7BBC7FC490")]
		public void ClickSuccess()
		{
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007995")]
		[Address(RVA = "0x1FFC494", Offset = "0x1FFC494", VA = "0x7BBC7FC494")]
		public void ResetTween()
		{
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007996")]
		[Address(RVA = "0x1FFC498", Offset = "0x1FFC498", VA = "0x7BBC7FC498")]
		public void OnDisable()
		{
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007997")]
		[Address(RVA = "0x1FFC49C", Offset = "0x1FFC49C", VA = "0x7BBC7FC49C")]
		private void OnChooseMapSuccess(params object[] data)
		{
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007998")]
		[Address(RVA = "0x1FFC5B0", Offset = "0x1FFC5B0", VA = "0x7BBC7FC5B0")]
		private void OnHLDefaultMap(params object[] data)
		{
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007999")]
		[Address(RVA = "0x1FFC82C", Offset = "0x1FFC82C", VA = "0x7BBC7FC82C")]
		public UIToggleButton GetModeToggleButton()
		{
			return null;
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00021708 File Offset: 0x0001F908
		[Token(Token = "0x600799A")]
		[Address(RVA = "0x1FFC858", Offset = "0x1FFC858", VA = "0x7BBC7FC858")]
		public int GetItemWidth()
		{
			return 0;
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600799B")]
		[Address(RVA = "0x1FFC898", Offset = "0x1FFC898", VA = "0x7BBC7FC898")]
		private void MapPanelVisibilityChanged(params object[] data)
		{
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600799C")]
		[Address(RVA = "0x1FFC9C8", Offset = "0x1FFC9C8", VA = "0x7BBC7FC9C8")]
		private void RefreshDownloader(params object[] data)
		{
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600799D")]
		[Address(RVA = "0x1FFCB2C", Offset = "0x1FFCB2C", VA = "0x7BBC7FCB2C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x00021720 File Offset: 0x0001F920
		[Token(Token = "0x600799E")]
		[Address(RVA = "0x1FFCC50", Offset = "0x1FFCC50", VA = "0x7BBC7FCC50", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00021738 File Offset: 0x0001F938
		[Token(Token = "0x600799F")]
		[Address(RVA = "0x1FFAD5C", Offset = "0x1FFAD5C", VA = "0x7BBC7FAD5C")]
		private bool IsPinnedClassicMode(MapModeData mapModeData)
		{
			return default(bool);
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A0")]
		[Address(RVA = "0x1FFCC94", Offset = "0x1FFCC94", VA = "0x7BBC7FCC94")]
		public UIGameModeBaseItemController()
		{
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A1")]
		[Address(RVA = "0x1FFCD34", Offset = "0x1FFCD34", VA = "0x7BBC7FCD34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114218C", Offset = "0x114218C")]
		private void <SetMapModeUI>b__17_0()
		{
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A2")]
		[Address(RVA = "0x1FFCE24", Offset = "0x1FFCE24", VA = "0x7BBC7FCE24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114219C", Offset = "0x114219C")]
		private void <OnModeBtnClick>b__22_0()
		{
		}

		// Token: 0x04008ECA RID: 36554
		[Token(Token = "0x4008ECA")]
		[FieldOffset(Offset = "0x58")]
		public UIGameModeMainController GameModeMainController;

		// Token: 0x04008ECB RID: 36555
		[Token(Token = "0x4008ECB")]
		[FieldOffset(Offset = "0x60")]
		private List<MapModeData> m_MapDataList;

		// Token: 0x04008ECC RID: 36556
		[Token(Token = "0x4008ECC")]
		[FieldOffset(Offset = "0x68")]
		private MapModeData m_SelectedMapData;

		// Token: 0x04008ECD RID: 36557
		[Token(Token = "0x4008ECD")]
		[FieldOffset(Offset = "0x70")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x04008ECE RID: 36558
		[Token(Token = "0x4008ECE")]
		[FieldOffset(Offset = "0x78")]
		protected UIGameModeBaseItemView m_View;

		// Token: 0x04008ECF RID: 36559
		[Token(Token = "0x4008ECF")]
		[FieldOffset(Offset = "0x80")]
		private EGameModeUIType m_UIType;

		// Token: 0x04008ED0 RID: 36560
		[Token(Token = "0x4008ED0")]
		[FieldOffset(Offset = "0x88")]
		private UICommonOptionalDownloaderController m_Downloader;

		// Token: 0x04008ED1 RID: 36561
		[Token(Token = "0x4008ED1")]
		[FieldOffset(Offset = "0x90")]
		protected int m_depth;

		// Token: 0x04008ED2 RID: 36562
		[Token(Token = "0x4008ED2")]
		[FieldOffset(Offset = "0x98")]
		protected List<ResourceID> m_NeedDownloadRes;

		// Token: 0x04008ED3 RID: 36563
		[Token(Token = "0x4008ED3")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_DelayCall;

		// Token: 0x04008ED4 RID: 36564
		[Token(Token = "0x4008ED4")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_CDNTextureDirty;

		// Token: 0x02001841 RID: 6209
		[Token(Token = "0x2001841")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3A6C", Offset = "0x10F3A6C")]
		private sealed class <clipCDNTextureCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060079A3 RID: 31139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A3")]
			[Address(RVA = "0x1FFBA98", Offset = "0x1FFBA98", VA = "0x7BBC7FBA98")]
			[DebuggerHidden]
			public <clipCDNTextureCoroutine>d__18(int <>1__state)
			{
			}

			// Token: 0x060079A4 RID: 31140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A4")]
			[Address(RVA = "0x1FFD258", Offset = "0x1FFD258", VA = "0x7BBC7FD258", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060079A5 RID: 31141 RVA: 0x00021750 File Offset: 0x0001F950
			[Token(Token = "0x60079A5")]
			[Address(RVA = "0x1FFD25C", Offset = "0x1FFD25C", VA = "0x7BBC7FD25C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x060079A6 RID: 31142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000970")]
			private object Current
			{
				[Token(Token = "0x60079A6")]
				[Address(RVA = "0x1FFD304", Offset = "0x1FFD304", VA = "0x7BBC7FD304", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060079A7 RID: 31143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A7")]
			[Address(RVA = "0x1FFD30C", Offset = "0x1FFD30C", VA = "0x7BBC7FD30C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x060079A8 RID: 31144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000971")]
			private object Current
			{
				[Token(Token = "0x60079A8")]
				[Address(RVA = "0x1FFD374", Offset = "0x1FFD374", VA = "0x7BBC7FD374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008ED5 RID: 36565
			[Token(Token = "0x4008ED5")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008ED6 RID: 36566
			[Token(Token = "0x4008ED6")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008ED7 RID: 36567
			[Token(Token = "0x4008ED7")]
			[FieldOffset(Offset = "0x20")]
			public UIGameModeBaseItemController <>4__this;
		}

		// Token: 0x02001842 RID: 6210
		[Token(Token = "0x2001842")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3A7C", Offset = "0x10F3A7C")]
		private sealed class <SetOpenDetailsUI>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060079A9 RID: 31145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079A9")]
			[Address(RVA = "0x1FFBE58", Offset = "0x1FFBE58", VA = "0x7BBC7FBE58")]
			[DebuggerHidden]
			public <SetOpenDetailsUI>d__20(int <>1__state)
			{
			}

			// Token: 0x060079AA RID: 31146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AA")]
			[Address(RVA = "0x1FFCF40", Offset = "0x1FFCF40", VA = "0x7BBC7FCF40", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060079AB RID: 31147 RVA: 0x00021768 File Offset: 0x0001F968
			[Token(Token = "0x60079AB")]
			[Address(RVA = "0x1FFCF44", Offset = "0x1FFCF44", VA = "0x7BBC7FCF44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x060079AC RID: 31148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000972")]
			private object Current
			{
				[Token(Token = "0x60079AC")]
				[Address(RVA = "0x1FFD1E0", Offset = "0x1FFD1E0", VA = "0x7BBC7FD1E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060079AD RID: 31149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AD")]
			[Address(RVA = "0x1FFD1E8", Offset = "0x1FFD1E8", VA = "0x7BBC7FD1E8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x060079AE RID: 31150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000973")]
			private object Current
			{
				[Token(Token = "0x60079AE")]
				[Address(RVA = "0x1FFD250", Offset = "0x1FFD250", VA = "0x7BBC7FD250", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008ED8 RID: 36568
			[Token(Token = "0x4008ED8")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008ED9 RID: 36569
			[Token(Token = "0x4008ED9")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008EDA RID: 36570
			[Token(Token = "0x4008EDA")]
			[FieldOffset(Offset = "0x20")]
			public UIGameModeBaseItemController <>4__this;
		}

		// Token: 0x02001843 RID: 6211
		[Token(Token = "0x2001843")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3A8C", Offset = "0x10F3A8C")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x060079AF RID: 31151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60079AF")]
			[Address(RVA = "0x1FFC824", Offset = "0x1FFC824", VA = "0x7BBC7FC824")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x060079B0 RID: 31152 RVA: 0x00021780 File Offset: 0x0001F980
			[Token(Token = "0x60079B0")]
			[Address(RVA = "0x1FFCEFC", Offset = "0x1FFCEFC", VA = "0x7BBC7FCEFC")]
			internal bool <OnHLDefaultMap>b__0(MapModeData a)
			{
				return default(bool);
			}

			// Token: 0x04008EDB RID: 36571
			[Token(Token = "0x4008EDB")]
			[FieldOffset(Offset = "0x10")]
			public MapModeData mapdata;
		}
	}
}
