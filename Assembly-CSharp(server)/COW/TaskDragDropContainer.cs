using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025D9 RID: 9689
	[Token(Token = "0x20025D9")]
	public class TaskDragDropContainer : UIDragDropContainer
	{
		// Token: 0x0600C73E RID: 51006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C73E")]
		[Address(RVA = "0x1B43E3C", Offset = "0x1B43E3C", VA = "0x7BBC343E3C")]
		private void Awake()
		{
		}

		// Token: 0x0600C73F RID: 51007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C73F")]
		[Address(RVA = "0x1B43E44", Offset = "0x1B43E44", VA = "0x7BBC343E44", Slot = "5")]
		public virtual void OnAddItem(TaskDragDropItem item)
		{
		}

		// Token: 0x0600C740 RID: 51008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C740")]
		[Address(RVA = "0x1B43FEC", Offset = "0x1B43FEC", VA = "0x7BBC343FEC", Slot = "6")]
		public virtual void OnRemoveItem(TaskDragDropItem item)
		{
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x00035688 File Offset: 0x00033888
		[Token(Token = "0x600C741")]
		[Address(RVA = "0x1B44030", Offset = "0x1B44030", VA = "0x7BBC344030", Slot = "7")]
		public virtual bool Check()
		{
			return default(bool);
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C742")]
		[Address(RVA = "0x1B44040", Offset = "0x1B44040", VA = "0x7BBC344040")]
		public TaskDragDropContainer()
		{
		}

		// Token: 0x0400F98A RID: 63882
		[Token(Token = "0x400F98A")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] targetPosition;

		// Token: 0x0400F98B RID: 63883
		[Token(Token = "0x400F98B")]
		[FieldOffset(Offset = "0x28")]
		public bool attached;

		// Token: 0x0400F98C RID: 63884
		[Token(Token = "0x400F98C")]
		[FieldOffset(Offset = "0x2C")]
		public new int tag;

		// Token: 0x0400F98D RID: 63885
		[Token(Token = "0x400F98D")]
		[FieldOffset(Offset = "0x30")]
		public int value;

		// Token: 0x0400F98E RID: 63886
		[Token(Token = "0x400F98E")]
		[FieldOffset(Offset = "0x34")]
		private int m_TarIdx;
	}
}
