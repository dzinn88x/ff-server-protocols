using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025D7 RID: 9687
	[Token(Token = "0x20025D7")]
	public class TaskDragDrop : BaseTask
	{
		// Token: 0x0600C736 RID: 50998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C736")]
		[Address(RVA = "0x1B43C20", Offset = "0x1B43C20", VA = "0x7BBC343C20")]
		private void Awake()
		{
		}

		// Token: 0x0600C737 RID: 50999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C737")]
		[Address(RVA = "0x1B43C2C", Offset = "0x1B43C2C", VA = "0x7BBC343C2C", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C738 RID: 51000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C738")]
		[Address(RVA = "0x1B43C54", Offset = "0x1B43C54", VA = "0x7BBC343C54")]
		private void CheckComplete()
		{
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C739")]
		[Address(RVA = "0x1B43D78", Offset = "0x1B43D78", VA = "0x7BBC343D78")]
		private void Update()
		{
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C73A")]
		[Address(RVA = "0x1B43D88", Offset = "0x1B43D88", VA = "0x7BBC343D88")]
		public TaskDragDrop()
		{
		}

		// Token: 0x0400F986 RID: 63878
		[Token(Token = "0x400F986")]
		[FieldOffset(Offset = "0x68")]
		public TaskDragDropContainer[] dragDropContainers;

		// Token: 0x0400F987 RID: 63879
		[Token(Token = "0x400F987")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsComplete;

		// Token: 0x020025D8 RID: 9688
		[Token(Token = "0x20025D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE84", Offset = "0x10FDE84")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600C73C RID: 51004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C73C")]
			[Address(RVA = "0x1B43DF4", Offset = "0x1B43DF4", VA = "0x7BBC343DF4")]
			public <>c()
			{
			}

			// Token: 0x0600C73D RID: 51005 RVA: 0x00035670 File Offset: 0x00033870
			[Token(Token = "0x600C73D")]
			[Address(RVA = "0x1B43DFC", Offset = "0x1B43DFC", VA = "0x7BBC343DFC")]
			internal bool <CheckComplete>b__4_0(TaskDragDropContainer container)
			{
				return default(bool);
			}

			// Token: 0x0400F988 RID: 63880
			[Token(Token = "0x400F988")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TaskDragDrop.<>c <>9;

			// Token: 0x0400F989 RID: 63881
			[Token(Token = "0x400F989")]
			[FieldOffset(Offset = "0x8")]
			public static Func<TaskDragDropContainer, bool> <>9__4_0;
		}
	}
}
