using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F4 RID: 5876
	[Token(Token = "0x20016F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1204", Offset = "0x10F1204")]
	public abstract class UIChatBaseContainerController : UIBaseController
	{
		// Token: 0x06006D17 RID: 27927
		[Token(Token = "0x6006D17")]
		public abstract GameObject GetContentNode();

		// Token: 0x06006D18 RID: 27928
		[Token(Token = "0x6006D18")]
		public abstract GameObject GetEmptyNode();

		// Token: 0x06006D19 RID: 27929
		[Token(Token = "0x6006D19")]
		public abstract UIScrollView GetMessageList();

		// Token: 0x06006D1A RID: 27930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0x1BDFA88", Offset = "0x1BDFA88", VA = "0x7BBC3DFA88", Slot = "31")]
		public virtual void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006D1B RID: 27931
		[Token(Token = "0x6006D1B")]
		public abstract void RefreshContentNode();

		// Token: 0x06006D1C RID: 27932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x1BDFC20", Offset = "0x1BDFC20", VA = "0x7BBC3DFC20")]
		protected UIChatBaseContainerController()
		{
		}
	}
}
