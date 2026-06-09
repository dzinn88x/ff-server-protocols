using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025D6 RID: 9686
	[Token(Token = "0x20025D6")]
	public class TaskBlend : BaseTask
	{
		// Token: 0x0600C72F RID: 50991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72F")]
		[Address(RVA = "0x1B43504", Offset = "0x1B43504", VA = "0x7BBC343504")]
		private void Awake()
		{
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C730")]
		[Address(RVA = "0x1B435E8", Offset = "0x1B435E8", VA = "0x7BBC3435E8", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C731")]
		[Address(RVA = "0x1B43678", Offset = "0x1B43678", VA = "0x7BBC343678")]
		private void OnPressLeft(bool isPress)
		{
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C732")]
		[Address(RVA = "0x1B43684", Offset = "0x1B43684", VA = "0x7BBC343684")]
		private void OnPressRight(bool isPress)
		{
		}

		// Token: 0x0600C733 RID: 50995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C733")]
		[Address(RVA = "0x1B43690", Offset = "0x1B43690", VA = "0x7BBC343690")]
		private void CheckComplete()
		{
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C734")]
		[Address(RVA = "0x1B43760", Offset = "0x1B43760", VA = "0x7BBC343760")]
		private void Update()
		{
		}

		// Token: 0x0600C735 RID: 50997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C735")]
		[Address(RVA = "0x1B438D0", Offset = "0x1B438D0", VA = "0x7BBC3438D0")]
		public TaskBlend()
		{
		}

		// Token: 0x0400F97B RID: 63867
		[Token(Token = "0x400F97B")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar progressBar;

		// Token: 0x0400F97C RID: 63868
		[Token(Token = "0x400F97C")]
		[FieldOffset(Offset = "0x70")]
		public UIProgressBar progressBarLeft;

		// Token: 0x0400F97D RID: 63869
		[Token(Token = "0x400F97D")]
		[FieldOffset(Offset = "0x78")]
		public UIProgressBar progressBarRight;

		// Token: 0x0400F97E RID: 63870
		[Token(Token = "0x400F97E")]
		[FieldOffset(Offset = "0x80")]
		public UICustomHoverButton pressButtonLeft;

		// Token: 0x0400F97F RID: 63871
		[Token(Token = "0x400F97F")]
		[FieldOffset(Offset = "0x88")]
		public UICustomHoverButton pressButtonRight;

		// Token: 0x0400F980 RID: 63872
		[Token(Token = "0x400F980")]
		[FieldOffset(Offset = "0x90")]
		public float completeTime;

		// Token: 0x0400F981 RID: 63873
		[Token(Token = "0x400F981")]
		[FieldOffset(Offset = "0x94")]
		private float m_CurLeftTime;

		// Token: 0x0400F982 RID: 63874
		[Token(Token = "0x400F982")]
		[FieldOffset(Offset = "0x98")]
		private float m_CurRightTime;

		// Token: 0x0400F983 RID: 63875
		[Token(Token = "0x400F983")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_IsLeftRun;

		// Token: 0x0400F984 RID: 63876
		[Token(Token = "0x400F984")]
		[FieldOffset(Offset = "0x9D")]
		private bool m_IsRightRun;

		// Token: 0x0400F985 RID: 63877
		[Token(Token = "0x400F985")]
		[FieldOffset(Offset = "0x9E")]
		private bool m_IsComplete;
	}
}
