using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025DA RID: 9690
	[Token(Token = "0x20025DA")]
	public class TaskDragDropItem : UIDragDropItem
	{
		// Token: 0x0600C743 RID: 51011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C743")]
		[Address(RVA = "0x1B44048", Offset = "0x1B44048", VA = "0x7BBC344048", Slot = "7")]
		protected override void Start()
		{
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C744")]
		[Address(RVA = "0x1B44194", Offset = "0x1B44194", VA = "0x7BBC344194", Slot = "18")]
		protected override void OnDragDropStart()
		{
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C745")]
		[Address(RVA = "0x1B442AC", Offset = "0x1B442AC", VA = "0x7BBC3442AC", Slot = "20")]
		protected override void OnDragDropRelease(GameObject surface)
		{
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C746")]
		[Address(RVA = "0x1B445F4", Offset = "0x1B445F4", VA = "0x7BBC3445F4")]
		public TaskDragDropItem()
		{
		}

		// Token: 0x0400F98F RID: 63887
		[Token(Token = "0x400F98F")]
		[FieldOffset(Offset = "0xB8")]
		public new int tag;

		// Token: 0x0400F990 RID: 63888
		[Token(Token = "0x400F990")]
		[FieldOffset(Offset = "0xBC")]
		public int value;

		// Token: 0x0400F991 RID: 63889
		[Token(Token = "0x400F991")]
		[FieldOffset(Offset = "0xC0")]
		public string soundStartDrag;

		// Token: 0x0400F992 RID: 63890
		[Token(Token = "0x400F992")]
		[FieldOffset(Offset = "0xC8")]
		public string soundReleaseDrag;

		// Token: 0x0400F993 RID: 63891
		[Token(Token = "0x400F993")]
		[FieldOffset(Offset = "0xD0")]
		private TaskDragDropContainer m_LastDrop;

		// Token: 0x0400F994 RID: 63892
		[Token(Token = "0x400F994")]
		[FieldOffset(Offset = "0xD8")]
		private ResourceID m_resStartDrag;

		// Token: 0x0400F995 RID: 63893
		[Token(Token = "0x400F995")]
		[FieldOffset(Offset = "0xDC")]
		private ResourceID m_resReleaseDrag;
	}
}
