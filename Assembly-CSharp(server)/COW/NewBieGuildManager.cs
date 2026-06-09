using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002050 RID: 8272
	[Token(Token = "0x2002050")]
	public class NewBieGuildManager : SingletonModule<NewBieGuildManager>
	{
		// Token: 0x0600B831 RID: 47153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B831")]
		[Address(RVA = "0x1A612F8", Offset = "0x1A612F8", VA = "0x7BBC2612F8", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B832")]
		[Address(RVA = "0x1A61358", Offset = "0x1A61358", VA = "0x7BBC261358", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B833")]
		[Address(RVA = "0x1A613C0", Offset = "0x1A613C0", VA = "0x7BBC2613C0")]
		public void SetToGuide(bool flag)
		{
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B834")]
		[Address(RVA = "0x1A613CC", Offset = "0x1A613CC", VA = "0x7BBC2613CC")]
		private void InitGuideList()
		{
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B835")]
		[Address(RVA = "0x1A61914", Offset = "0x1A61914", VA = "0x7BBC261914")]
		public void SetWidgets(UIWidget[] widgetArray)
		{
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B836")]
		[Address(RVA = "0x1A61B94", Offset = "0x1A61B94", VA = "0x7BBC261B94")]
		public void SetBtnStartWidget(UIWidget newWidget)
		{
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B837")]
		[Address(RVA = "0x1A61B9C", Offset = "0x1A61B9C", VA = "0x7BBC261B9C")]
		public void ClearRefenceWidgets()
		{
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B838")]
		[Address(RVA = "0x1A61C94", Offset = "0x1A61C94", VA = "0x7BBC261C94")]
		public void OpenGuide()
		{
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B839")]
		[Address(RVA = "0x1A61E98", Offset = "0x1A61E98", VA = "0x7BBC261E98")]
		private void UpdateClickMask()
		{
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83A")]
		[Address(RVA = "0x1A604D4", Offset = "0x1A604D4", VA = "0x7BBC2604D4")]
		public void CloseClickMask()
		{
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x00034BD8 File Offset: 0x00032DD8
		[Token(Token = "0x600B83B")]
		[Address(RVA = "0x1A62040", Offset = "0x1A62040", VA = "0x7BBC262040")]
		public bool CheckInGuide()
		{
			return default(bool);
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x00034BF0 File Offset: 0x00032DF0
		[Token(Token = "0x600B83C")]
		[Address(RVA = "0x1A62050", Offset = "0x1A62050", VA = "0x7BBC262050")]
		public bool CheckInRankingGuide()
		{
			return default(bool);
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x00034C08 File Offset: 0x00032E08
		[Token(Token = "0x600B83D")]
		[Address(RVA = "0x1A620D8", Offset = "0x1A620D8", VA = "0x7BBC2620D8")]
		public NewbieGuideId GetCurrentGuideId()
		{
			return NewbieGuideId.None;
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83E")]
		[Address(RVA = "0x1A61CEC", Offset = "0x1A61CEC", VA = "0x7BBC261CEC")]
		public void CloseGuide()
		{
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83F")]
		[Address(RVA = "0x1A620F0", Offset = "0x1A620F0", VA = "0x7BBC2620F0")]
		public void HideCurGuide()
		{
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x00034C20 File Offset: 0x00032E20
		[Token(Token = "0x600B840")]
		[Address(RVA = "0x1A621AC", Offset = "0x1A621AC", VA = "0x7BBC2621AC")]
		public bool CheckCanGuide(NewbieGuideId guideID)
		{
			return default(bool);
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B841")]
		[Address(RVA = "0x1A61D9C", Offset = "0x1A61D9C", VA = "0x7BBC261D9C")]
		private void ChooseGuide()
		{
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B842")]
		[Address(RVA = "0x1A622A4", Offset = "0x1A622A4", VA = "0x7BBC2622A4")]
		public NewBieGuildManager()
		{
		}

		// Token: 0x0400BA4B RID: 47691
		[Token(Token = "0x400BA4B")]
		[FieldOffset(Offset = "0x12")]
		private bool m_IsNeedGuide;

		// Token: 0x0400BA4C RID: 47692
		[Token(Token = "0x400BA4C")]
		[FieldOffset(Offset = "0x18")]
		private NewBieGuildBasProcessor m_CurretGuide;

		// Token: 0x0400BA4D RID: 47693
		[Token(Token = "0x400BA4D")]
		[FieldOffset(Offset = "0x20")]
		private List<NewBieGuildBasProcessor> m_NewBieGuideList;

		// Token: 0x0400BA4E RID: 47694
		[Token(Token = "0x400BA4E")]
		[FieldOffset(Offset = "0x28")]
		private UIRightReigonClickMask m_ClickMask;

		// Token: 0x0400BA4F RID: 47695
		[Token(Token = "0x400BA4F")]
		[FieldOffset(Offset = "0x30")]
		private UIWidget m_BtnStartWidget;

		// Token: 0x02002051 RID: 8273
		[Token(Token = "0x2002051")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD934", Offset = "0x10FD934")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B844 RID: 47172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B844")]
			[Address(RVA = "0x1A62378", Offset = "0x1A62378", VA = "0x7BBC262378")]
			public <>c()
			{
			}

			// Token: 0x0600B845 RID: 47173 RVA: 0x00034C38 File Offset: 0x00032E38
			[Token(Token = "0x600B845")]
			[Address(RVA = "0x1A62380", Offset = "0x1A62380", VA = "0x7BBC262380")]
			internal int <SetWidgets>b__9_0(NewBieGuildBasProcessor a, NewBieGuildBasProcessor b)
			{
				return 0;
			}

			// Token: 0x0400BA50 RID: 47696
			[Token(Token = "0x400BA50")]
			[FieldOffset(Offset = "0x0")]
			public static readonly NewBieGuildManager.<>c <>9;

			// Token: 0x0400BA51 RID: 47697
			[Token(Token = "0x400BA51")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<NewBieGuildBasProcessor> <>9__9_0;
		}

		// Token: 0x02002052 RID: 8274
		[Token(Token = "0x2002052")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD944", Offset = "0x10FD944")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x0600B846 RID: 47174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B846")]
			[Address(RVA = "0x1A6229C", Offset = "0x1A6229C", VA = "0x7BBC26229C")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x0600B847 RID: 47175 RVA: 0x00034C50 File Offset: 0x00032E50
			[Token(Token = "0x600B847")]
			[Address(RVA = "0x1A623D0", Offset = "0x1A623D0", VA = "0x7BBC2623D0")]
			internal bool <CheckCanGuide>b__0(NewBieGuildBasProcessor x)
			{
				return default(bool);
			}

			// Token: 0x0400BA52 RID: 47698
			[Token(Token = "0x400BA52")]
			[FieldOffset(Offset = "0x10")]
			public NewbieGuideId guideID;
		}
	}
}
