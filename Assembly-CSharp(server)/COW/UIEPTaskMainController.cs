using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014FF RID: 5375
	[Token(Token = "0x20014FF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDF34", Offset = "0x10EDF34")]
	public class UIEPTaskMainController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005C3F RID: 23615 RVA: 0x0001AE20 File Offset: 0x00019020
		[Token(Token = "0x6005C3F")]
		[Address(RVA = "0x1ACF894", Offset = "0x1ACF894", VA = "0x7BBC2CF894")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C40")]
		[Address(RVA = "0x1ACF8E4", Offset = "0x1ACF8E4", VA = "0x7BBC2CF8E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x1ACFF48", Offset = "0x1ACFF48", VA = "0x7BBC2CFF48", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x1ACFF50", Offset = "0x1ACFF50", VA = "0x7BBC2CFF50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x1ACFA44", Offset = "0x1ACFA44", VA = "0x7BBC2CFA44")]
		private void InitTab()
		{
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x1AD0230", Offset = "0x1AD0230", VA = "0x7BBC2D0230")]
		private void UpdateTabTip(params object[] data)
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x1AD0024", Offset = "0x1AD0024", VA = "0x7BBC2D0024")]
		private void CreateTabs(UIEPTaskMainController.TaskData data)
		{
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x1AD0494", Offset = "0x1AD0494", VA = "0x7BBC2D0494")]
		private void OnSelectTab(UIEPTaskMainController.TaskTab tab, int index = 0)
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x1AD099C", Offset = "0x1AD099C", VA = "0x7BBC2D099C")]
		public void GotoTab(UIEPTaskMainController.TaskTab tab)
		{
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x1AD0B6C", Offset = "0x1AD0B6C", VA = "0x7BBC2D0B6C")]
		public void ShowSignIn()
		{
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x1AD0E48", Offset = "0x1AD0E48", VA = "0x7BBC2D0E48")]
		private void OnCloseClick()
		{
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x1AD0E50", Offset = "0x1AD0E50", VA = "0x7BBC2D0E50", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x0001AE38 File Offset: 0x00019038
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x1AD0EB8", Offset = "0x1AD0EB8", VA = "0x7BBC2D0EB8", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x1AD0F20", Offset = "0x1AD0F20", VA = "0x7BBC2D0F20")]
		public UIEPTaskMainController()
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x1AD0FE0", Offset = "0x1AD0FE0", VA = "0x7BBC2D0FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F7E0", Offset = "0x113F7E0")]
		private UIBaseController <InitTab>b__14_0()
		{
			return null;
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x1AD109C", Offset = "0x1AD109C", VA = "0x7BBC2D109C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F7F0", Offset = "0x113F7F0")]
		private UIBaseController <InitTab>b__14_1()
		{
			return null;
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x1AD1158", Offset = "0x1AD1158", VA = "0x7BBC2D1158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F800", Offset = "0x113F800")]
		private UIBaseController <InitTab>b__14_2()
		{
			return null;
		}

		// Token: 0x04007E6F RID: 32367
		[Token(Token = "0x4007E6F")]
		[FieldOffset(Offset = "0x98")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x04007E70 RID: 32368
		[Token(Token = "0x4007E70")]
		[FieldOffset(Offset = "0xA0")]
		private UIEPTaskMainView m_View;

		// Token: 0x04007E71 RID: 32369
		[Token(Token = "0x4007E71")]
		[FieldOffset(Offset = "0xA8")]
		private UIEPTaskMainController.TaskTab m_CurrentTab;

		// Token: 0x04007E72 RID: 32370
		[Token(Token = "0x4007E72")]
		[FieldOffset(Offset = "0xB0")]
		private List<UIEPTaskMainController.TaskData> m_TaskDatas;

		// Token: 0x04007E73 RID: 32371
		[Token(Token = "0x4007E73")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<UIEPTaskMainController.TaskTab, UIBaseController> m_CtrlDic;

		// Token: 0x04007E74 RID: 32372
		[Token(Token = "0x4007E74")]
		[FieldOffset(Offset = "0xC0")]
		private List<StandardTopTabItemViewData> m_TabDataList;

		// Token: 0x04007E75 RID: 32373
		[Token(Token = "0x4007E75")]
		[FieldOffset(Offset = "0xC8")]
		private UIStandardTopTabController m_TabCtrl;

		// Token: 0x04007E76 RID: 32374
		[Token(Token = "0x4007E76")]
		private const string Default_Icon_Name = "UI_Icon_DailyRewards";

		// Token: 0x02001500 RID: 5376
		[Token(Token = "0x2001500")]
		public enum TaskTab
		{
			// Token: 0x04007E78 RID: 32376
			[Token(Token = "0x4007E78")]
			None,
			// Token: 0x04007E79 RID: 32377
			[Token(Token = "0x4007E79")]
			Daily,
			// Token: 0x04007E7A RID: 32378
			[Token(Token = "0x4007E7A")]
			Weekly,
			// Token: 0x04007E7B RID: 32379
			[Token(Token = "0x4007E7B")]
			Challenge
		}

		// Token: 0x02001501 RID: 5377
		[Token(Token = "0x2001501")]
		public class TaskData
		{
			// Token: 0x06005C50 RID: 23632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C50")]
			[Address(RVA = "0x1AD001C", Offset = "0x1AD001C", VA = "0x7BBC2D001C")]
			public TaskData()
			{
			}

			// Token: 0x04007E7C RID: 32380
			[Token(Token = "0x4007E7C")]
			[FieldOffset(Offset = "0x10")]
			public UIEPTaskMainController.TaskTab m_Tab;

			// Token: 0x04007E7D RID: 32381
			[Token(Token = "0x4007E7D")]
			[FieldOffset(Offset = "0x18")]
			public string m_Title;

			// Token: 0x04007E7E RID: 32382
			[Token(Token = "0x4007E7E")]
			[FieldOffset(Offset = "0x20")]
			public ETipsType m_RedDot;

			// Token: 0x04007E7F RID: 32383
			[Token(Token = "0x4007E7F")]
			[FieldOffset(Offset = "0x28")]
			public Func<UIBaseController> m_OnSelect;

			// Token: 0x04007E80 RID: 32384
			[Token(Token = "0x4007E80")]
			[FieldOffset(Offset = "0x30")]
			public bool m_SpecialRedDot;
		}

		// Token: 0x02001502 RID: 5378
		[Token(Token = "0x2001502")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF6C", Offset = "0x10EDF6C")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06005C51 RID: 23633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C51")]
			[Address(RVA = "0x1AD048C", Offset = "0x1AD048C", VA = "0x7BBC2D048C")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06005C52 RID: 23634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C52")]
			[Address(RVA = "0x1AD1214", Offset = "0x1AD1214", VA = "0x7BBC2D1214")]
			internal void <CreateTabs>b__0()
			{
			}

			// Token: 0x04007E81 RID: 32385
			[Token(Token = "0x4007E81")]
			[FieldOffset(Offset = "0x10")]
			public UIEPTaskMainController <>4__this;

			// Token: 0x04007E82 RID: 32386
			[Token(Token = "0x4007E82")]
			[FieldOffset(Offset = "0x18")]
			public UIEPTaskMainController.TaskData data;

			// Token: 0x04007E83 RID: 32387
			[Token(Token = "0x4007E83")]
			[FieldOffset(Offset = "0x20")]
			public int index;
		}

		// Token: 0x02001503 RID: 5379
		[Token(Token = "0x2001503")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF7C", Offset = "0x10EDF7C")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x06005C53 RID: 23635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C53")]
			[Address(RVA = "0x1AD0994", Offset = "0x1AD0994", VA = "0x7BBC2D0994")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06005C54 RID: 23636 RVA: 0x0001AE50 File Offset: 0x00019050
			[Token(Token = "0x6005C54")]
			[Address(RVA = "0x1AD1268", Offset = "0x1AD1268", VA = "0x7BBC2D1268")]
			internal bool <OnSelectTab>b__0(UIEPTaskMainController.TaskData temp)
			{
				return default(bool);
			}

			// Token: 0x04007E84 RID: 32388
			[Token(Token = "0x4007E84")]
			[FieldOffset(Offset = "0x10")]
			public UIEPTaskMainController.TaskTab tab;
		}

		// Token: 0x02001504 RID: 5380
		[Token(Token = "0x2001504")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF8C", Offset = "0x10EDF8C")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06005C55 RID: 23637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C55")]
			[Address(RVA = "0x1AD0B5C", Offset = "0x1AD0B5C", VA = "0x7BBC2D0B5C")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06005C56 RID: 23638 RVA: 0x0001AE68 File Offset: 0x00019068
			[Token(Token = "0x6005C56")]
			[Address(RVA = "0x1AD12A4", Offset = "0x1AD12A4", VA = "0x7BBC2D12A4")]
			internal bool <GotoTab>b__0(UIEPTaskMainController.TaskData e)
			{
				return default(bool);
			}

			// Token: 0x04007E85 RID: 32389
			[Token(Token = "0x4007E85")]
			[FieldOffset(Offset = "0x10")]
			public UIEPTaskMainController.TaskTab tab;
		}

		// Token: 0x02001505 RID: 5381
		[Token(Token = "0x2001505")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDF9C", Offset = "0x10EDF9C")]
		private sealed class <>c__DisplayClass18_1
		{
			// Token: 0x06005C57 RID: 23639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C57")]
			[Address(RVA = "0x1AD0B64", Offset = "0x1AD0B64", VA = "0x7BBC2D0B64")]
			public <>c__DisplayClass18_1()
			{
			}

			// Token: 0x06005C58 RID: 23640 RVA: 0x0001AE80 File Offset: 0x00019080
			[Token(Token = "0x6005C58")]
			[Address(RVA = "0x1AD12E0", Offset = "0x1AD12E0", VA = "0x7BBC2D12E0")]
			internal bool <GotoTab>b__1(StandardTopTabItemViewData e)
			{
				return default(bool);
			}

			// Token: 0x04007E86 RID: 32390
			[Token(Token = "0x4007E86")]
			[FieldOffset(Offset = "0x10")]
			public UIEPTaskMainController.TaskData data;
		}
	}
}
