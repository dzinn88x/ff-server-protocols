using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025D5 RID: 9685
	[Token(Token = "0x20025D5")]
	public class TaskBalance : BaseTask
	{
		// Token: 0x0600C72A RID: 50986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72A")]
		[Address(RVA = "0x1B431A8", Offset = "0x1B431A8", VA = "0x7BBC3431A8")]
		private void Awake()
		{
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72B")]
		[Address(RVA = "0x1B432BC", Offset = "0x1B432BC", VA = "0x7BBC3432BC", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72C")]
		[Address(RVA = "0x1B433B4", Offset = "0x1B433B4", VA = "0x7BBC3433B4")]
		private void CheckComplete()
		{
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72D")]
		[Address(RVA = "0x1B434EC", Offset = "0x1B434EC", VA = "0x7BBC3434EC")]
		private void Update()
		{
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C72E")]
		[Address(RVA = "0x1B434FC", Offset = "0x1B434FC", VA = "0x7BBC3434FC")]
		public TaskBalance()
		{
		}

		// Token: 0x0400F976 RID: 63862
		[Token(Token = "0x400F976")]
		[FieldOffset(Offset = "0x68")]
		public new UITweener[] animations;

		// Token: 0x0400F977 RID: 63863
		[Token(Token = "0x400F977")]
		[FieldOffset(Offset = "0x70")]
		public TaskDragDropContainer dragDropContainer;

		// Token: 0x0400F978 RID: 63864
		[Token(Token = "0x400F978")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsComplete;

		// Token: 0x0400F979 RID: 63865
		[Token(Token = "0x400F979")]
		[FieldOffset(Offset = "0x80")]
		public string balanceSound;

		// Token: 0x0400F97A RID: 63866
		[Token(Token = "0x400F97A")]
		[FieldOffset(Offset = "0x88")]
		private ResourceID m_resBalanceSound;
	}
}
