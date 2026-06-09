using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001277 RID: 4727
	[Token(Token = "0x2001277")]
	public abstract class StatedTaggedTriggerDelegator : TriggerDelegator
	{
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x1700083A")]
		public bool IsInTriggers
		{
			[Token(Token = "0x600492A")]
			[Address(RVA = "0x1B3F950", Offset = "0x1B3F950", VA = "0x7BBC33F950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x1B3F9BC", Offset = "0x1B3F9BC", VA = "0x7BBC33F9BC", Slot = "5")]
		protected override void OnEnterTriggerChecked(Collider other)
		{
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x1B3FB1C", Offset = "0x1B3FB1C", VA = "0x7BBC33FB1C", Slot = "6")]
		protected override void OnExitTriggerChecked(Collider other)
		{
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492D")]
		[Address(RVA = "0x1B3FA84", Offset = "0x1B3FA84", VA = "0x7BBC33FA84")]
		private void CallActionForCount(Action a, int i)
		{
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492E")]
		[Address(RVA = "0x1B3FBE4", Offset = "0x1B3FBE4", VA = "0x7BBC33FBE4")]
		public void Clear()
		{
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492F")]
		[Address(RVA = "0x1B3FC44", Offset = "0x1B3FC44", VA = "0x7BBC33FC44")]
		protected StatedTaggedTriggerDelegator()
		{
		}

		// Token: 0x04007217 RID: 29207
		[Token(Token = "0x4007217")]
		[FieldOffset(Offset = "0x30")]
		private List<int> m_WithinTriggers;

		// Token: 0x04007218 RID: 29208
		[Token(Token = "0x4007218")]
		[FieldOffset(Offset = "0x38")]
		public Action OnEnterState;

		// Token: 0x04007219 RID: 29209
		[Token(Token = "0x4007219")]
		[FieldOffset(Offset = "0x40")]
		public Action OnExitState;
	}
}
