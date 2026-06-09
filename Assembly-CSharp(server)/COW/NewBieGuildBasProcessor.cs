using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002047 RID: 8263
	[Token(Token = "0x2002047")]
	public class NewBieGuildBasProcessor
	{
		// Token: 0x0600B811 RID: 47121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B811")]
		[Address(RVA = "0x1A5E7B0", Offset = "0x1A5E7B0", VA = "0x7BBC25E7B0")]
		public NewBieGuildBasProcessor()
		{
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x00034B90 File Offset: 0x00032D90
		[Token(Token = "0x600B812")]
		[Address(RVA = "0x1A5EAA0", Offset = "0x1A5EAA0", VA = "0x7BBC25EAA0")]
		public NewbieGuideId GetNewBieGuideId()
		{
			return NewbieGuideId.None;
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B813")]
		[Address(RVA = "0x1A5EAA8", Offset = "0x1A5EAA8", VA = "0x7BBC25EAA8")]
		public void SetHandWidget(UIWidget wd)
		{
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B814")]
		[Address(RVA = "0x1A5EAB0", Offset = "0x1A5EAB0", VA = "0x7BBC25EAB0")]
		public void ClearHandWidget()
		{
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B815")]
		[Address(RVA = "0x1A5EAB8", Offset = "0x1A5EAB8", VA = "0x7BBC25EAB8", Slot = "4")]
		public virtual void NewBieGuideInit()
		{
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x00034BA8 File Offset: 0x00032DA8
		[Token(Token = "0x600B816")]
		[Address(RVA = "0x1A5ED0C", Offset = "0x1A5ED0C", VA = "0x7BBC25ED0C", Slot = "5")]
		public virtual bool CheckCanGuide()
		{
			return default(bool);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x00034BC0 File Offset: 0x00032DC0
		[Token(Token = "0x600B817")]
		[Address(RVA = "0x1A5F7A4", Offset = "0x1A5F7A4", VA = "0x7BBC25F7A4")]
		private bool CheckGuideCondition(int condinum, int valuenum)
		{
			return default(bool);
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B818")]
		[Address(RVA = "0x1A603F0", Offset = "0x1A603F0", VA = "0x7BBC2603F0")]
		public void FinishGuide()
		{
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B819")]
		[Address(RVA = "0x1A5EA04", Offset = "0x1A5EA04", VA = "0x7BBC25EA04", Slot = "6")]
		public virtual void DoGuild()
		{
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B81A")]
		[Address(RVA = "0x1A604E8", Offset = "0x1A604E8", VA = "0x7BBC2604E8", Slot = "7")]
		public virtual void CloseGuild()
		{
		}

		// Token: 0x0400BA3D RID: 47677
		[Token(Token = "0x400BA3D")]
		[FieldOffset(Offset = "0x10")]
		protected NewbieGuideId m_newbieid;

		// Token: 0x0400BA3E RID: 47678
		[Token(Token = "0x400BA3E")]
		[FieldOffset(Offset = "0x14")]
		public uint m_prority;

		// Token: 0x0400BA3F RID: 47679
		[Token(Token = "0x400BA3F")]
		[FieldOffset(Offset = "0x18")]
		protected string m_newbieguidekey;

		// Token: 0x0400BA40 RID: 47680
		[Token(Token = "0x400BA40")]
		[FieldOffset(Offset = "0x20")]
		protected List<NewBieGuildBasProcessor.NewBieGuideCondition> m_ConditionList;

		// Token: 0x0400BA41 RID: 47681
		[Token(Token = "0x400BA41")]
		[FieldOffset(Offset = "0x28")]
		public UICommonGuideController m_NewbieGuideCtrl;

		// Token: 0x0400BA42 RID: 47682
		[Token(Token = "0x400BA42")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget m_HandPoint;

		// Token: 0x02002048 RID: 8264
		[Token(Token = "0x2002048")]
		public struct NewBieGuideCondition
		{
			// Token: 0x0600B81B RID: 47131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B81B")]
			[Address(RVA = "0x11F091C", Offset = "0x11F091C", VA = "0x7BBB9F091C")]
			public void SetGuideVal(int pre1, int val1, int pre2, int val2, int pre3, int val3, int pre4, int val4)
			{
			}

			// Token: 0x0400BA43 RID: 47683
			[Token(Token = "0x400BA43")]
			[FieldOffset(Offset = "0x0")]
			public int precdt1;

			// Token: 0x0400BA44 RID: 47684
			[Token(Token = "0x400BA44")]
			[FieldOffset(Offset = "0x4")]
			public int value1;

			// Token: 0x0400BA45 RID: 47685
			[Token(Token = "0x400BA45")]
			[FieldOffset(Offset = "0x8")]
			public int precdt2;

			// Token: 0x0400BA46 RID: 47686
			[Token(Token = "0x400BA46")]
			[FieldOffset(Offset = "0xC")]
			public int value2;

			// Token: 0x0400BA47 RID: 47687
			[Token(Token = "0x400BA47")]
			[FieldOffset(Offset = "0x10")]
			public int precdt3;

			// Token: 0x0400BA48 RID: 47688
			[Token(Token = "0x400BA48")]
			[FieldOffset(Offset = "0x14")]
			public int value3;

			// Token: 0x0400BA49 RID: 47689
			[Token(Token = "0x400BA49")]
			[FieldOffset(Offset = "0x18")]
			public int precdt4;

			// Token: 0x0400BA4A RID: 47690
			[Token(Token = "0x400BA4A")]
			[FieldOffset(Offset = "0x1C")]
			public int value4;
		}
	}
}
