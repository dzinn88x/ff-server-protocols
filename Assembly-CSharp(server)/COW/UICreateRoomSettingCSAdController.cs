using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001774 RID: 6004
	[Token(Token = "0x2001774")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2154", Offset = "0x10F2154")]
	internal class UICreateRoomSettingCSAdController : UIBaseController
	{
		// Token: 0x060071B7 RID: 29111 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Token(Token = "0x60071B7")]
		[Address(RVA = "0x1B9F768", Offset = "0x1B9F768", VA = "0x7BBC39F768")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B8")]
		[Address(RVA = "0x1B9F7B8", Offset = "0x1B9F7B8", VA = "0x7BBC39F7B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B9")]
		[Address(RVA = "0x1B9FCE0", Offset = "0x1B9FCE0", VA = "0x7BBC39FCE0")]
		private void InitDefaultSettings()
		{
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BA")]
		[Address(RVA = "0x1BA06AC", Offset = "0x1BA06AC", VA = "0x7BBC3A06AC")]
		private void OnToggleADCSClick()
		{
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BB")]
		[Address(RVA = "0x1BA08C4", Offset = "0x1BA08C4", VA = "0x7BBC3A08C4")]
		public void ResetOpen()
		{
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BC")]
		[Address(RVA = "0x1BA0A4C", Offset = "0x1BA0A4C", VA = "0x7BBC3A0A4C")]
		private void OnBtnTipsClick()
		{
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BD")]
		[Address(RVA = "0x1BA0C70", Offset = "0x1BA0C70", VA = "0x7BBC3A0C70")]
		private void OnMaskClick()
		{
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BE")]
		[Address(RVA = "0x1BA0E4C", Offset = "0x1BA0E4C", VA = "0x7BBC3A0E4C")]
		public void SetIsCSMode(bool isCS)
		{
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BF")]
		[Address(RVA = "0x1B9FE88", Offset = "0x1B9FE88", VA = "0x7BBC39FE88")]
		private void InitStoreSettings()
		{
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C0")]
		[Address(RVA = "0x1BA155C", Offset = "0x1BA155C", VA = "0x7BBC3A155C")]
		private List<PopMenuData> GenerateWeaponDropList()
		{
			return null;
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C1")]
		[Address(RVA = "0x1BA17D8", Offset = "0x1BA17D8", VA = "0x7BBC3A17D8")]
		private void RefreshWeaponGrid(uint typeTab)
		{
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C2")]
		[Address(RVA = "0x1BA10FC", Offset = "0x1BA10FC", VA = "0x7BBC3A10FC")]
		private void InitShopControllers(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSShopData shopData)
		{
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0x1BA0298", Offset = "0x1BA0298", VA = "0x7BBC3A0298")]
		private void InitEcoSettings()
		{
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0x1BA1E6C", Offset = "0x1BA1E6C", VA = "0x7BBC3A1E6C")]
		private List<PopMenuData> GenerateRoundDropList()
		{
			return null;
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C5")]
		[Address(RVA = "0x1BA204C", Offset = "0x1BA204C", VA = "0x7BBC3A204C")]
		private void RefreshRoundGrid(int round)
		{
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C6")]
		[Address(RVA = "0x1BA19C4", Offset = "0x1BA19C4", VA = "0x7BBC3A19C4")]
		private void InitRoundController(UIRoomCheckSliderTemplateController ctrl, int index)
		{
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C7")]
		[Address(RVA = "0x1BA1C48", Offset = "0x1BA1C48", VA = "0x7BBC3A1C48")]
		private void InitEcoController(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSEcoData data)
		{
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C8")]
		[Address(RVA = "0x1BA22C4", Offset = "0x1BA22C4", VA = "0x7BBC3A22C4")]
		private void OnToggleSettingClick()
		{
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0x1BA248C", Offset = "0x1BA248C", VA = "0x7BBC3A248C")]
		public void ResetADCSToggle()
		{
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CA")]
		[Address(RVA = "0x1BA0624", Offset = "0x1BA0624", VA = "0x7BBC3A0624")]
		private void RefreshSelectedShopItemCnt()
		{
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CB")]
		[Address(RVA = "0x1BA1398", Offset = "0x1BA1398", VA = "0x7BBC3A1398")]
		public void RepositionAllSettings(bool delayTableReposition = false)
		{
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071CC")]
		[Address(RVA = "0x1BA24F4", Offset = "0x1BA24F4", VA = "0x7BBC3A24F4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114187C", Offset = "0x114187C")]
		private IEnumerator TableReposition()
		{
			return null;
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CD")]
		[Address(RVA = "0x1BA2594", Offset = "0x1BA2594", VA = "0x7BBC3A2594")]
		public UICreateRoomSettingCSAdController()
		{
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CE")]
		[Address(RVA = "0x1BA2A3C", Offset = "0x1BA2A3C", VA = "0x7BBC3A2A3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11418E0", Offset = "0x11418E0")]
		private void <GenerateWeaponDropList>b__22_0(object obj)
		{
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CF")]
		[Address(RVA = "0x1BA2AA8", Offset = "0x1BA2AA8", VA = "0x7BBC3A2AA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11418F0", Offset = "0x11418F0")]
		private void <GenerateRoundDropList>b__26_0(object obj)
		{
		}

		// Token: 0x04008B11 RID: 35601
		[Token(Token = "0x4008B11")]
		[FieldOffset(Offset = "0x58")]
		protected UICreateRoomSettingCSAdView m_View;

		// Token: 0x04008B12 RID: 35602
		[Token(Token = "0x4008B12")]
		[FieldOffset(Offset = "0x60")]
		protected RoomCreateRuleDataManager m_DataManager;

		// Token: 0x04008B13 RID: 35603
		[Token(Token = "0x4008B13")]
		[FieldOffset(Offset = "0x68")]
		protected UIModelCustomRoom m_CustomRoomModel;

		// Token: 0x04008B14 RID: 35604
		[Token(Token = "0x4008B14")]
		[FieldOffset(Offset = "0x70")]
		private uint m_WeaponTypeTab;

		// Token: 0x04008B15 RID: 35605
		[Token(Token = "0x4008B15")]
		[FieldOffset(Offset = "0x74")]
		private int m_RoundCnt;

		// Token: 0x04008B16 RID: 35606
		[Token(Token = "0x4008B16")]
		[FieldOffset(Offset = "0x78")]
		private int m_CSShopMaxCost;

		// Token: 0x04008B17 RID: 35607
		[Token(Token = "0x4008B17")]
		[FieldOffset(Offset = "0x7C")]
		private int m_CSShopCostInterval;

		// Token: 0x04008B18 RID: 35608
		[Token(Token = "0x4008B18")]
		[FieldOffset(Offset = "0x80")]
		private string m_ItemName;

		// Token: 0x04008B19 RID: 35609
		[Token(Token = "0x4008B19")]
		private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_TOGGLE";

		// Token: 0x04008B1A RID: 35610
		[Token(Token = "0x4008B1A")]
		[FieldOffset(Offset = "0x88")]
		private List<UIRoomCheckSliderTemplateController> m_CachedWeaponControllers;

		// Token: 0x04008B1B RID: 35611
		[Token(Token = "0x4008B1B")]
		[FieldOffset(Offset = "0x90")]
		private List<UIRoomCheckSliderTemplateController> m_CachedRoundControllers;

		// Token: 0x04008B1C RID: 35612
		[Token(Token = "0x4008B1C")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<UICreateRoomSettingCSAdController.TabType, string> TAB_TYPE_NAME;

		// Token: 0x02001775 RID: 6005
		[Token(Token = "0x2001775")]
		private enum TabType
		{
			// Token: 0x04008B1E RID: 35614
			[Token(Token = "0x4008B1E")]
			ALL,
			// Token: 0x04008B1F RID: 35615
			[Token(Token = "0x4008B1F")]
			RIFLE,
			// Token: 0x04008B20 RID: 35616
			[Token(Token = "0x4008B20")]
			SNIPER,
			// Token: 0x04008B21 RID: 35617
			[Token(Token = "0x4008B21")]
			PISTOL,
			// Token: 0x04008B22 RID: 35618
			[Token(Token = "0x4008B22")]
			SUBMACHINE,
			// Token: 0x04008B23 RID: 35619
			[Token(Token = "0x4008B23")]
			SHOTGUN,
			// Token: 0x04008B24 RID: 35620
			[Token(Token = "0x4008B24")]
			MELEE,
			// Token: 0x04008B25 RID: 35621
			[Token(Token = "0x4008B25")]
			THROWING,
			// Token: 0x04008B26 RID: 35622
			[Token(Token = "0x4008B26")]
			SPECIAL
		}

		// Token: 0x02001776 RID: 6006
		[Token(Token = "0x2001776")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F218C", Offset = "0x10F218C")]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x060071D0 RID: 29136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D0")]
			[Address(RVA = "0x1BA19BC", Offset = "0x1BA19BC", VA = "0x7BBC3A19BC")]
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x060071D1 RID: 29137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D1")]
			[Address(RVA = "0x1BA2B38", Offset = "0x1BA2B38", VA = "0x7BBC3A2B38")]
			internal void <InitShopControllers>b__0(int val)
			{
			}

			// Token: 0x060071D2 RID: 29138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D2")]
			[Address(RVA = "0x1BA2BC0", Offset = "0x1BA2BC0", VA = "0x7BBC3A2BC0")]
			internal void <InitShopControllers>b__1(bool val)
			{
			}

			// Token: 0x04008B27 RID: 35623
			[Token(Token = "0x4008B27")]
			[FieldOffset(Offset = "0x10")]
			public UICreateRoomSettingCSAdController <>4__this;

			// Token: 0x04008B28 RID: 35624
			[Token(Token = "0x4008B28")]
			[FieldOffset(Offset = "0x18")]
			public RoomCreateCSShopData shopData;
		}

		// Token: 0x02001777 RID: 6007
		[Token(Token = "0x2001777")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F219C", Offset = "0x10F219C")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x060071D3 RID: 29139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D3")]
			[Address(RVA = "0x1BA22B4", Offset = "0x1BA22B4", VA = "0x7BBC3A22B4")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x060071D4 RID: 29140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D4")]
			[Address(RVA = "0x1BA2C44", Offset = "0x1BA2C44", VA = "0x7BBC3A2C44")]
			internal void <InitRoundController>b__0(int val)
			{
			}

			// Token: 0x04008B29 RID: 35625
			[Token(Token = "0x4008B29")]
			[FieldOffset(Offset = "0x10")]
			public UICreateRoomSettingCSAdController <>4__this;

			// Token: 0x04008B2A RID: 35626
			[Token(Token = "0x4008B2A")]
			[FieldOffset(Offset = "0x18")]
			public int index;
		}

		// Token: 0x02001778 RID: 6008
		[Token(Token = "0x2001778")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F21AC", Offset = "0x10F21AC")]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x060071D5 RID: 29141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D5")]
			[Address(RVA = "0x1BA22BC", Offset = "0x1BA22BC", VA = "0x7BBC3A22BC")]
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x060071D6 RID: 29142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D6")]
			[Address(RVA = "0x1BA2CA0", Offset = "0x1BA2CA0", VA = "0x7BBC3A2CA0")]
			internal void <InitEcoController>b__0(int val)
			{
			}

			// Token: 0x04008B2B RID: 35627
			[Token(Token = "0x4008B2B")]
			[FieldOffset(Offset = "0x10")]
			public UICreateRoomSettingCSAdController <>4__this;

			// Token: 0x04008B2C RID: 35628
			[Token(Token = "0x4008B2C")]
			[FieldOffset(Offset = "0x18")]
			public RoomCreateCSEcoData data;
		}

		// Token: 0x02001779 RID: 6009
		[Token(Token = "0x2001779")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F21BC", Offset = "0x10F21BC")]
		private sealed class <TableReposition>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060071D7 RID: 29143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D7")]
			[Address(RVA = "0x1BA2568", Offset = "0x1BA2568", VA = "0x7BBC3A2568")]
			[DebuggerHidden]
			public <TableReposition>d__34(int <>1__state)
			{
			}

			// Token: 0x060071D8 RID: 29144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071D8")]
			[Address(RVA = "0x1BA2D54", Offset = "0x1BA2D54", VA = "0x7BBC3A2D54", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060071D9 RID: 29145 RVA: 0x0001FB00 File Offset: 0x0001DD00
			[Token(Token = "0x60071D9")]
			[Address(RVA = "0x1BA2D58", Offset = "0x1BA2D58", VA = "0x7BBC3A2D58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x060071DA RID: 29146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700093A")]
			private object Current
			{
				[Token(Token = "0x60071DA")]
				[Address(RVA = "0x1BA2E60", Offset = "0x1BA2E60", VA = "0x7BBC3A2E60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060071DB RID: 29147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071DB")]
			[Address(RVA = "0x1BA2E68", Offset = "0x1BA2E68", VA = "0x7BBC3A2E68", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x060071DC RID: 29148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700093B")]
			private object Current
			{
				[Token(Token = "0x60071DC")]
				[Address(RVA = "0x1BA2ED0", Offset = "0x1BA2ED0", VA = "0x7BBC3A2ED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008B2D RID: 35629
			[Token(Token = "0x4008B2D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008B2E RID: 35630
			[Token(Token = "0x4008B2E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008B2F RID: 35631
			[Token(Token = "0x4008B2F")]
			[FieldOffset(Offset = "0x20")]
			public UICreateRoomSettingCSAdController <>4__this;
		}
	}
}
