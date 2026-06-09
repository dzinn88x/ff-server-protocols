using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020020B4 RID: 8372
	[Token(Token = "0x20020B4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDDFC", Offset = "0x10FDDFC")]
	public class UITokenTipsBtnItemController : UIBaseController
	{
		// Token: 0x0600BC6E RID: 48238 RVA: 0x00035430 File Offset: 0x00033630
		[Token(Token = "0x600BC6E")]
		[Address(RVA = "0x1F55D70", Offset = "0x1F55D70", VA = "0x7BBC755D70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BC6F RID: 48239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6F")]
		[Address(RVA = "0x1F55DC0", Offset = "0x1F55DC0", VA = "0x7BBC755DC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BC70 RID: 48240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC70")]
		[Address(RVA = "0x1F55EA4", Offset = "0x1F55EA4", VA = "0x7BBC755EA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC71")]
		[Address(RVA = "0x1F55EAC", Offset = "0x1F55EAC", VA = "0x7BBC755EAC")]
		public void SetData(string des, uint gopos, uint subgopos, uint tokenId)
		{
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC72")]
		[Address(RVA = "0x1F55FBC", Offset = "0x1F55FBC", VA = "0x7BBC755FBC")]
		private void OnGoClick()
		{
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC73")]
		[Address(RVA = "0x1F560D8", Offset = "0x1F560D8", VA = "0x7BBC7560D8")]
		public UITokenTipsBtnItemController()
		{
		}

		// Token: 0x0400BD06 RID: 48390
		[Token(Token = "0x400BD06")]
		[FieldOffset(Offset = "0x58")]
		private UITokenTipsBtnItemView m_View;

		// Token: 0x0400BD07 RID: 48391
		[Token(Token = "0x400BD07")]
		[FieldOffset(Offset = "0x60")]
		private uint m_Gopos;

		// Token: 0x0400BD08 RID: 48392
		[Token(Token = "0x400BD08")]
		[FieldOffset(Offset = "0x64")]
		private uint m_SubGopos;

		// Token: 0x0400BD09 RID: 48393
		[Token(Token = "0x400BD09")]
		[FieldOffset(Offset = "0x68")]
		private uint m_TokenId;
	}
}
