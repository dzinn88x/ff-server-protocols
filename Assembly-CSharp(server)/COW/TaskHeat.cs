using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025DB RID: 9691
	[Token(Token = "0x20025DB")]
	public class TaskHeat : BaseTask
	{
		// Token: 0x0600C747 RID: 51015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C747")]
		[Address(RVA = "0x1B4465C", Offset = "0x1B4465C", VA = "0x7BBC34465C")]
		private void Awake()
		{
		}

		// Token: 0x0600C748 RID: 51016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C748")]
		[Address(RVA = "0x1B4477C", Offset = "0x1B4477C", VA = "0x7BBC34477C", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C749")]
		[Address(RVA = "0x1B44890", Offset = "0x1B44890", VA = "0x7BBC344890")]
		private void OnPress(bool isPress)
		{
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74A")]
		[Address(RVA = "0x1B4499C", Offset = "0x1B4499C", VA = "0x7BBC34499C")]
		private void OnClick()
		{
		}

		// Token: 0x0600C74B RID: 51019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74B")]
		[Address(RVA = "0x1B448A8", Offset = "0x1B448A8", VA = "0x7BBC3448A8")]
		private void CheckComplete()
		{
		}

		// Token: 0x0600C74C RID: 51020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74C")]
		[Address(RVA = "0x1B449A4", Offset = "0x1B449A4", VA = "0x7BBC3449A4", Slot = "6")]
		public override void OnFailure()
		{
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74D")]
		[Address(RVA = "0x1B449D4", Offset = "0x1B449D4", VA = "0x7BBC3449D4", Slot = "9")]
		public override void Resume()
		{
		}

		// Token: 0x0600C74E RID: 51022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74E")]
		[Address(RVA = "0x1B44A00", Offset = "0x1B44A00", VA = "0x7BBC344A00", Slot = "8")]
		public override void Pause()
		{
		}

		// Token: 0x0600C74F RID: 51023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74F")]
		[Address(RVA = "0x1B44A2C", Offset = "0x1B44A2C", VA = "0x7BBC344A2C")]
		private void Update()
		{
		}

		// Token: 0x0600C750 RID: 51024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C750")]
		[Address(RVA = "0x1B44AE8", Offset = "0x1B44AE8", VA = "0x7BBC344AE8")]
		public TaskHeat()
		{
		}

		// Token: 0x0400F996 RID: 63894
		[Token(Token = "0x400F996")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar progressBar;

		// Token: 0x0400F997 RID: 63895
		[Token(Token = "0x400F997")]
		[FieldOffset(Offset = "0x70")]
		public UIProgressBar targetBarLeft;

		// Token: 0x0400F998 RID: 63896
		[Token(Token = "0x400F998")]
		[FieldOffset(Offset = "0x78")]
		public UIProgressBar targetBarRight;

		// Token: 0x0400F999 RID: 63897
		[Token(Token = "0x400F999")]
		[FieldOffset(Offset = "0x80")]
		public UICustomHoverButton pressButton;

		// Token: 0x0400F99A RID: 63898
		[Token(Token = "0x400F99A")]
		[FieldOffset(Offset = "0x88")]
		public bool clickStop;

		// Token: 0x0400F99B RID: 63899
		[Token(Token = "0x400F99B")]
		[FieldOffset(Offset = "0x89")]
		public bool pingpong;

		// Token: 0x0400F99C RID: 63900
		[Token(Token = "0x400F99C")]
		[FieldOffset(Offset = "0x8C")]
		public float leftRange;

		// Token: 0x0400F99D RID: 63901
		[Token(Token = "0x400F99D")]
		[FieldOffset(Offset = "0x90")]
		public float targetRange;

		// Token: 0x0400F99E RID: 63902
		[Token(Token = "0x400F99E")]
		[FieldOffset(Offset = "0x94")]
		public float completeTime;

		// Token: 0x0400F99F RID: 63903
		[Token(Token = "0x400F99F")]
		[FieldOffset(Offset = "0x98")]
		private float m_CurTime;

		// Token: 0x0400F9A0 RID: 63904
		[Token(Token = "0x400F9A0")]
		[FieldOffset(Offset = "0x9C")]
		private float m_TargetValue;

		// Token: 0x0400F9A1 RID: 63905
		[Token(Token = "0x400F9A1")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_IsRun;

		// Token: 0x0400F9A2 RID: 63906
		[Token(Token = "0x400F9A2")]
		[FieldOffset(Offset = "0xA4")]
		private int m_Dir;
	}
}
