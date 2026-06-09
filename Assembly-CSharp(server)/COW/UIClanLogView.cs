using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216C RID: 8556
	[Token(Token = "0x200216C")]
	internal class UIClanLogView : UIBaseView
	{
		// Token: 0x0600BDE8 RID: 48616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE8")]
		[Address(RVA = "0x1CFDE8C", Offset = "0x1CFDE8C", VA = "0x7BBC4FDE8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE9")]
		[Address(RVA = "0x1CFE000", Offset = "0x1CFE000", VA = "0x7BBC4FE000")]
		public UIClanLogView()
		{
		}

		// Token: 0x0400C619 RID: 50713
		[Token(Token = "0x400C619")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView MessageList;

		// Token: 0x0400C61A RID: 50714
		[Token(Token = "0x400C61A")]
		[FieldOffset(Offset = "0x28")]
		public UITable MessageListTable;

		// Token: 0x0400C61B RID: 50715
		[Token(Token = "0x400C61B")]
		[FieldOffset(Offset = "0x30")]
		public UIClanLogItemView ItemInstance;

		// Token: 0x0400C61C RID: 50716
		[Token(Token = "0x400C61C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject EmptyNode;
	}
}
