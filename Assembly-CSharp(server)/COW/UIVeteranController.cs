using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BCA RID: 7114
	[Token(Token = "0x2001BCA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAE04", Offset = "0x10FAE04")]
	internal class UIVeteranController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060099D0 RID: 39376 RVA: 0x000287D0 File Offset: 0x000269D0
		[Token(Token = "0x60099D0")]
		[Address(RVA = "0x1A0BC3C", Offset = "0x1A0BC3C", VA = "0x7BBC20BC3C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D1")]
		[Address(RVA = "0x1A0BC8C", Offset = "0x1A0BC8C", VA = "0x7BBC20BC8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D2")]
		[Address(RVA = "0x1A0C72C", Offset = "0x1A0C72C", VA = "0x7BBC20C72C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D3")]
		[Address(RVA = "0x1A0C770", Offset = "0x1A0C770", VA = "0x7BBC20C770")]
		private void OnClickClose()
		{
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D4")]
		[Address(RVA = "0x1A0C3D0", Offset = "0x1A0C3D0", VA = "0x7BBC20C3D0")]
		private void CreateTabs(UIVeteranController.TabData data)
		{
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D5")]
		[Address(RVA = "0x1A0C780", Offset = "0x1A0C780", VA = "0x7BBC20C780")]
		public void GotoTab(UIVeteranController.ETab tab)
		{
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D6")]
		[Address(RVA = "0x1A0C840", Offset = "0x1A0C840", VA = "0x7BBC20C840")]
		private void OnSelectTab(UIVeteranController.ETab tab)
		{
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x000287E8 File Offset: 0x000269E8
		[Token(Token = "0x60099D7")]
		[Address(RVA = "0x1A0CB94", Offset = "0x1A0CB94", VA = "0x7BBC20CB94", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D8")]
		[Address(RVA = "0x1A0CBD8", Offset = "0x1A0CBD8", VA = "0x7BBC20CBD8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099D9")]
		[Address(RVA = "0x1A0CC50", Offset = "0x1A0CC50", VA = "0x7BBC20CC50")]
		private void UpdateTime()
		{
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DA")]
		[Address(RVA = "0x1A0CD5C", Offset = "0x1A0CD5C", VA = "0x7BBC20CD5C")]
		public UIVeteranController()
		{
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099DB")]
		[Address(RVA = "0x1A0CE1C", Offset = "0x1A0CE1C", VA = "0x7BBC20CE1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F78", Offset = "0x1144F78")]
		private UIBaseController <OnUIInit>b__9_0()
		{
			return null;
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099DC")]
		[Address(RVA = "0x1A0CEB8", Offset = "0x1A0CEB8", VA = "0x7BBC20CEB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F88", Offset = "0x1144F88")]
		private UIBaseController <OnUIInit>b__9_1()
		{
			return null;
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099DD")]
		[Address(RVA = "0x1A0CF54", Offset = "0x1A0CF54", VA = "0x7BBC20CF54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F98", Offset = "0x1144F98")]
		private UIBaseController <OnUIInit>b__9_2()
		{
			return null;
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099DE")]
		[Address(RVA = "0x1A0CFF0", Offset = "0x1A0CFF0", VA = "0x7BBC20CFF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144FA8", Offset = "0x1144FA8")]
		private void <UpdateTime>b__17_0()
		{
		}

		// Token: 0x0400A0EA RID: 41194
		[Token(Token = "0x400A0EA")]
		[FieldOffset(Offset = "0x98")]
		private UIVeteranView m_View;

		// Token: 0x0400A0EB RID: 41195
		[Token(Token = "0x400A0EB")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIVeteranController.TabData> m_TaskDatas;

		// Token: 0x0400A0EC RID: 41196
		[Token(Token = "0x400A0EC")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<UIVeteranController.ETab, UIBaseController> m_CtrlDict;

		// Token: 0x0400A0ED RID: 41197
		[Token(Token = "0x400A0ED")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<UIVeteranController.ETab, UIToggleButton> m_TabDict;

		// Token: 0x0400A0EE RID: 41198
		[Token(Token = "0x400A0EE")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelVeteranSignin m_Model;

		// Token: 0x0400A0EF RID: 41199
		[Token(Token = "0x400A0EF")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelVeteranBundle m_BundleModel;

		// Token: 0x02001BCB RID: 7115
		[Token(Token = "0x2001BCB")]
		public enum ETab
		{
			// Token: 0x0400A0F1 RID: 41201
			[Token(Token = "0x400A0F1")]
			Signin,
			// Token: 0x0400A0F2 RID: 41202
			[Token(Token = "0x400A0F2")]
			Task,
			// Token: 0x0400A0F3 RID: 41203
			[Token(Token = "0x400A0F3")]
			Bundle
		}

		// Token: 0x02001BCC RID: 7116
		[Token(Token = "0x2001BCC")]
		public class TabData
		{
			// Token: 0x060099DF RID: 39391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099DF")]
			[Address(RVA = "0x1A0C3C8", Offset = "0x1A0C3C8", VA = "0x7BBC20C3C8")]
			public TabData()
			{
			}

			// Token: 0x0400A0F4 RID: 41204
			[Token(Token = "0x400A0F4")]
			[FieldOffset(Offset = "0x10")]
			public UIVeteranController.ETab m_Tab;

			// Token: 0x0400A0F5 RID: 41205
			[Token(Token = "0x400A0F5")]
			[FieldOffset(Offset = "0x18")]
			public string m_Title;

			// Token: 0x0400A0F6 RID: 41206
			[Token(Token = "0x400A0F6")]
			[FieldOffset(Offset = "0x20")]
			public ETipsType m_RedDot;

			// Token: 0x0400A0F7 RID: 41207
			[Token(Token = "0x400A0F7")]
			[FieldOffset(Offset = "0x28")]
			public Func<UIBaseController> m_OnSelect;
		}

		// Token: 0x02001BCD RID: 7117
		[Token(Token = "0x2001BCD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAE3C", Offset = "0x10FAE3C")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060099E0 RID: 39392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099E0")]
			[Address(RVA = "0x1A0C778", Offset = "0x1A0C778", VA = "0x7BBC20C778")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x060099E1 RID: 39393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099E1")]
			[Address(RVA = "0x1A0D0EC", Offset = "0x1A0D0EC", VA = "0x7BBC20D0EC")]
			internal void <CreateTabs>b__0()
			{
			}

			// Token: 0x0400A0F8 RID: 41208
			[Token(Token = "0x400A0F8")]
			[FieldOffset(Offset = "0x10")]
			public UIVeteranController <>4__this;

			// Token: 0x0400A0F9 RID: 41209
			[Token(Token = "0x400A0F9")]
			[FieldOffset(Offset = "0x18")]
			public UIVeteranController.TabData data;
		}

		// Token: 0x02001BCE RID: 7118
		[Token(Token = "0x2001BCE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAE4C", Offset = "0x10FAE4C")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060099E2 RID: 39394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099E2")]
			[Address(RVA = "0x1A0CB8C", Offset = "0x1A0CB8C", VA = "0x7BBC20CB8C")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x060099E3 RID: 39395 RVA: 0x00028800 File Offset: 0x00026A00
			[Token(Token = "0x60099E3")]
			[Address(RVA = "0x1A0D12C", Offset = "0x1A0D12C", VA = "0x7BBC20D12C")]
			internal bool <OnSelectTab>b__0(UIVeteranController.TabData temp)
			{
				return default(bool);
			}

			// Token: 0x0400A0FA RID: 41210
			[Token(Token = "0x400A0FA")]
			[FieldOffset(Offset = "0x10")]
			public UIVeteranController.ETab tab;
		}
	}
}
