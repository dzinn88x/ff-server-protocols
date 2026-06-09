using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025D4 RID: 9684
	[Token(Token = "0x20025D4")]
	public class TaskAuto : BaseTask
	{
		// Token: 0x0600C723 RID: 50979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C723")]
		[Address(RVA = "0x1B42EC4", Offset = "0x1B42EC4", VA = "0x7BBC342EC4")]
		private void Awake()
		{
		}

		// Token: 0x0600C724 RID: 50980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C724")]
		[Address(RVA = "0x1B42FE4", Offset = "0x1B42FE4", VA = "0x7BBC342FE4", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C725 RID: 50981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C725")]
		[Address(RVA = "0x1B43054", Offset = "0x1B43054", VA = "0x7BBC343054")]
		private void OnClick()
		{
		}

		// Token: 0x0600C726 RID: 50982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C726")]
		[Address(RVA = "0x1B43088", Offset = "0x1B43088", VA = "0x7BBC343088")]
		private void OnPress(bool isPress)
		{
		}

		// Token: 0x0600C727 RID: 50983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C727")]
		[Address(RVA = "0x1B430DC", Offset = "0x1B430DC", VA = "0x7BBC3430DC")]
		private void Update()
		{
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C728")]
		[Address(RVA = "0x1B4316C", Offset = "0x1B4316C", VA = "0x7BBC34316C", Slot = "8")]
		public override void Pause()
		{
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C729")]
		[Address(RVA = "0x1B43198", Offset = "0x1B43198", VA = "0x7BBC343198")]
		public TaskAuto()
		{
		}

		// Token: 0x0400F970 RID: 63856
		[Token(Token = "0x400F970")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar progressBar;

		// Token: 0x0400F971 RID: 63857
		[Token(Token = "0x400F971")]
		[FieldOffset(Offset = "0x70")]
		public UICustomHoverButton button;

		// Token: 0x0400F972 RID: 63858
		[Token(Token = "0x400F972")]
		[FieldOffset(Offset = "0x78")]
		public bool needPress;

		// Token: 0x0400F973 RID: 63859
		[Token(Token = "0x400F973")]
		[FieldOffset(Offset = "0x7C")]
		public float completeTime;

		// Token: 0x0400F974 RID: 63860
		[Token(Token = "0x400F974")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsRun;

		// Token: 0x0400F975 RID: 63861
		[Token(Token = "0x400F975")]
		[FieldOffset(Offset = "0x84")]
		private float m_CurTime;
	}
}
