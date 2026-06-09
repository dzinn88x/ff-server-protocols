using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BAB RID: 7083
	[Token(Token = "0x2001BAB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA9C4", Offset = "0x10FA9C4")]
	public class UITaskController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060098E2 RID: 39138 RVA: 0x00028410 File Offset: 0x00026610
		[Token(Token = "0x60098E2")]
		[Address(RVA = "0x1F50880", Offset = "0x1F50880", VA = "0x7BBC750880")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x00028428 File Offset: 0x00026628
		[Token(Token = "0x60098E3")]
		[Address(RVA = "0x1F508D0", Offset = "0x1F508D0", VA = "0x7BBC7508D0", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E4")]
		[Address(RVA = "0x1F508D8", Offset = "0x1F508D8", VA = "0x7BBC7508D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098E5")]
		[Address(RVA = "0x1F519F8", Offset = "0x1F519F8", VA = "0x7BBC7519F8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144DB0", Offset = "0x1144DB0")]
		private IEnumerator Routine()
		{
			return null;
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E6")]
		[Address(RVA = "0x1F51A98", Offset = "0x1F51A98", VA = "0x7BBC751A98", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E7")]
		[Address(RVA = "0x1F51AF0", Offset = "0x1F51AF0", VA = "0x7BBC751AF0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E8")]
		[Address(RVA = "0x1F51BFC", Offset = "0x1F51BFC", VA = "0x7BBC751BFC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E9")]
		[Address(RVA = "0x1F51C04", Offset = "0x1F51C04", VA = "0x7BBC751C04")]
		private void OnClickClose()
		{
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EA")]
		[Address(RVA = "0x1F51394", Offset = "0x1F51394", VA = "0x7BBC751394")]
		private void CreateTabs(UITaskController.TaskData data)
		{
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EB")]
		[Address(RVA = "0x1F51C14", Offset = "0x1F51C14", VA = "0x7BBC751C14")]
		public void GotoTab(UITaskController.TaskTab tab)
		{
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EC")]
		[Address(RVA = "0x1F51DB8", Offset = "0x1F51DB8", VA = "0x7BBC751DB8")]
		private void OnSelectTab(UITaskController.TaskTab tab)
		{
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098ED")]
		[Address(RVA = "0x1F522D0", Offset = "0x1F522D0", VA = "0x7BBC7522D0")]
		private void CloseWnd(params object[] data)
		{
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EE")]
		[Address(RVA = "0x1F522D8", Offset = "0x1F522D8", VA = "0x7BBC7522D8", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x00028440 File Offset: 0x00026640
		[Token(Token = "0x60098EF")]
		[Address(RVA = "0x1F52370", Offset = "0x1F52370", VA = "0x7BBC752370", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098F0")]
		[Address(RVA = "0x1F523B4", Offset = "0x1F523B4", VA = "0x7BBC7523B4")]
		public UITaskController()
		{
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098F1")]
		[Address(RVA = "0x1F52474", Offset = "0x1F52474", VA = "0x7BBC752474")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144E14", Offset = "0x1144E14")]
		private UIBaseController <OnUIInit>b__13_0()
		{
			return null;
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098F2")]
		[Address(RVA = "0x1F52530", Offset = "0x1F52530", VA = "0x7BBC752530")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144E24", Offset = "0x1144E24")]
		private UIBaseController <OnUIInit>b__13_1()
		{
			return null;
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60098F3")]
		[Address(RVA = "0x1F525EC", Offset = "0x1F525EC", VA = "0x7BBC7525EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144E34", Offset = "0x1144E34")]
		private UIBaseController <OnUIInit>b__13_2()
		{
			return null;
		}

		// Token: 0x0400A076 RID: 41078
		[Token(Token = "0x400A076")]
		[FieldOffset(Offset = "0x98")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400A077 RID: 41079
		[Token(Token = "0x400A077")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAnnouncement m_ModelAnnouncement;

		// Token: 0x0400A078 RID: 41080
		[Token(Token = "0x400A078")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x0400A079 RID: 41081
		[Token(Token = "0x400A079")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelUser m_ModelUser;

		// Token: 0x0400A07A RID: 41082
		[Token(Token = "0x400A07A")]
		[FieldOffset(Offset = "0xB8")]
		private UITaskView m_View;

		// Token: 0x0400A07B RID: 41083
		[Token(Token = "0x400A07B")]
		[FieldOffset(Offset = "0xC0")]
		private List<UITaskController.TaskData> m_TaskDatas;

		// Token: 0x0400A07C RID: 41084
		[Token(Token = "0x400A07C")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<UITaskController.TaskTab, UIBaseController> m_CtrlDict;

		// Token: 0x0400A07D RID: 41085
		[Token(Token = "0x400A07D")]
		[FieldOffset(Offset = "0xD0")]
		private List<StandardTopTabItemViewData> m_TabDataList;

		// Token: 0x0400A07E RID: 41086
		[Token(Token = "0x400A07E")]
		[FieldOffset(Offset = "0xD8")]
		private UIStandardTopTabController m_TabCtrl;

		// Token: 0x02001BAC RID: 7084
		[Token(Token = "0x2001BAC")]
		public enum TaskTab
		{
			// Token: 0x0400A080 RID: 41088
			[Token(Token = "0x400A080")]
			None,
			// Token: 0x0400A081 RID: 41089
			[Token(Token = "0x400A081")]
			ElitePass,
			// Token: 0x0400A082 RID: 41090
			[Token(Token = "0x400A082")]
			DailySignin,
			// Token: 0x0400A083 RID: 41091
			[Token(Token = "0x400A083")]
			DailyTask
		}

		// Token: 0x02001BAD RID: 7085
		[Token(Token = "0x2001BAD")]
		public class TaskData
		{
			// Token: 0x060098F4 RID: 39156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098F4")]
			[Address(RVA = "0x1F5138C", Offset = "0x1F5138C", VA = "0x7BBC75138C")]
			public TaskData()
			{
			}

			// Token: 0x0400A084 RID: 41092
			[Token(Token = "0x400A084")]
			[FieldOffset(Offset = "0x10")]
			public UITaskController.TaskTab m_TaskTab;

			// Token: 0x0400A085 RID: 41093
			[Token(Token = "0x400A085")]
			[FieldOffset(Offset = "0x18")]
			public string m_Title;

			// Token: 0x0400A086 RID: 41094
			[Token(Token = "0x400A086")]
			[FieldOffset(Offset = "0x20")]
			public ETipsType m_RedDot;

			// Token: 0x0400A087 RID: 41095
			[Token(Token = "0x400A087")]
			[FieldOffset(Offset = "0x28")]
			public Func<UIBaseController> m_OnSelect;

			// Token: 0x0400A088 RID: 41096
			[Token(Token = "0x400A088")]
			[FieldOffset(Offset = "0x30")]
			public bool hasRedDot;
		}

		// Token: 0x02001BAE RID: 7086
		[Token(Token = "0x2001BAE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FA9FC", Offset = "0x10FA9FC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060098F6 RID: 39158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098F6")]
			[Address(RVA = "0x1F5270C", Offset = "0x1F5270C", VA = "0x7BBC75270C")]
			public <>c()
			{
			}

			// Token: 0x060098F7 RID: 39159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098F7")]
			[Address(RVA = "0x1F52714", Offset = "0x1F52714", VA = "0x7BBC752714")]
			internal void <OnUIInit>b__13_3()
			{
			}

			// Token: 0x060098F8 RID: 39160 RVA: 0x00028458 File Offset: 0x00026658
			[Token(Token = "0x60098F8")]
			[Address(RVA = "0x1F527B4", Offset = "0x1F527B4", VA = "0x7BBC7527B4")]
			internal bool <OnUIInit>b__13_4(UITaskController.TaskData e)
			{
				return default(bool);
			}

			// Token: 0x0400A089 RID: 41097
			[Token(Token = "0x400A089")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UITaskController.<>c <>9;

			// Token: 0x0400A08A RID: 41098
			[Token(Token = "0x400A08A")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__13_3;

			// Token: 0x0400A08B RID: 41099
			[Token(Token = "0x400A08B")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<UITaskController.TaskData> <>9__13_4;
		}

		// Token: 0x02001BAF RID: 7087
		[Token(Token = "0x2001BAF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAA0C", Offset = "0x10FAA0C")]
		private sealed class <Routine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060098F9 RID: 39161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098F9")]
			[Address(RVA = "0x1F51A6C", Offset = "0x1F51A6C", VA = "0x7BBC751A6C")]
			[DebuggerHidden]
			public <Routine>d__14(int <>1__state)
			{
			}

			// Token: 0x060098FA RID: 39162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098FA")]
			[Address(RVA = "0x1F528E4", Offset = "0x1F528E4", VA = "0x7BBC7528E4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060098FB RID: 39163 RVA: 0x00028470 File Offset: 0x00026670
			[Token(Token = "0x60098FB")]
			[Address(RVA = "0x1F528E8", Offset = "0x1F528E8", VA = "0x7BBC7528E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x060098FC RID: 39164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A49")]
			private object Current
			{
				[Token(Token = "0x60098FC")]
				[Address(RVA = "0x1F5295C", Offset = "0x1F5295C", VA = "0x7BBC75295C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060098FD RID: 39165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098FD")]
			[Address(RVA = "0x1F52964", Offset = "0x1F52964", VA = "0x7BBC752964", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x060098FE RID: 39166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4A")]
			private object Current
			{
				[Token(Token = "0x60098FE")]
				[Address(RVA = "0x1F529CC", Offset = "0x1F529CC", VA = "0x7BBC7529CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A08C RID: 41100
			[Token(Token = "0x400A08C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A08D RID: 41101
			[Token(Token = "0x400A08D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A08E RID: 41102
			[Token(Token = "0x400A08E")]
			[FieldOffset(Offset = "0x20")]
			public UITaskController <>4__this;
		}

		// Token: 0x02001BB0 RID: 7088
		[Token(Token = "0x2001BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAA1C", Offset = "0x10FAA1C")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x060098FF RID: 39167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098FF")]
			[Address(RVA = "0x1F51C0C", Offset = "0x1F51C0C", VA = "0x7BBC751C0C")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06009900 RID: 39168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009900")]
			[Address(RVA = "0x1F527E0", Offset = "0x1F527E0", VA = "0x7BBC7527E0")]
			internal void <CreateTabs>b__0()
			{
			}

			// Token: 0x0400A08F RID: 41103
			[Token(Token = "0x400A08F")]
			[FieldOffset(Offset = "0x10")]
			public UITaskController <>4__this;

			// Token: 0x0400A090 RID: 41104
			[Token(Token = "0x400A090")]
			[FieldOffset(Offset = "0x18")]
			public UITaskController.TaskData data;
		}

		// Token: 0x02001BB1 RID: 7089
		[Token(Token = "0x2001BB1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAA2C", Offset = "0x10FAA2C")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06009901 RID: 39169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009901")]
			[Address(RVA = "0x1F51DB0", Offset = "0x1F51DB0", VA = "0x7BBC751DB0")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06009902 RID: 39170 RVA: 0x00028488 File Offset: 0x00026688
			[Token(Token = "0x6009902")]
			[Address(RVA = "0x1F52820", Offset = "0x1F52820", VA = "0x7BBC752820")]
			internal bool <GotoTab>b__0(UITaskController.TaskData x)
			{
				return default(bool);
			}

			// Token: 0x06009903 RID: 39171 RVA: 0x000284A0 File Offset: 0x000266A0
			[Token(Token = "0x6009903")]
			[Address(RVA = "0x1F5285C", Offset = "0x1F5285C", VA = "0x7BBC75285C")]
			internal bool <GotoTab>b__1(StandardTopTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x0400A091 RID: 41105
			[Token(Token = "0x400A091")]
			[FieldOffset(Offset = "0x10")]
			public UITaskController.TaskTab tab;

			// Token: 0x0400A092 RID: 41106
			[Token(Token = "0x400A092")]
			[FieldOffset(Offset = "0x18")]
			public UITaskController.TaskData data;
		}

		// Token: 0x02001BB2 RID: 7090
		[Token(Token = "0x2001BB2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAA3C", Offset = "0x10FAA3C")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06009904 RID: 39172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009904")]
			[Address(RVA = "0x1F522C8", Offset = "0x1F522C8", VA = "0x7BBC7522C8")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06009905 RID: 39173 RVA: 0x000284B8 File Offset: 0x000266B8
			[Token(Token = "0x6009905")]
			[Address(RVA = "0x1F528A8", Offset = "0x1F528A8", VA = "0x7BBC7528A8")]
			internal bool <OnSelectTab>b__0(UITaskController.TaskData temp)
			{
				return default(bool);
			}

			// Token: 0x0400A093 RID: 41107
			[Token(Token = "0x400A093")]
			[FieldOffset(Offset = "0x10")]
			public UITaskController.TaskTab tab;
		}
	}
}
