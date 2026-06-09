using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001825 RID: 6181
	[Token(Token = "0x2001825")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F377C", Offset = "0x10F377C")]
	public class UIGachaTurntableBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x060078C6 RID: 30918 RVA: 0x00021408 File Offset: 0x0001F608
		[Token(Token = "0x60078C6")]
		[Address(RVA = "0x1FA9C88", Offset = "0x1FA9C88", VA = "0x7BBC7A9C88")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078C7")]
		[Address(RVA = "0x1FA9CD8", Offset = "0x1FA9CD8", VA = "0x7BBC7A9CD8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078C8")]
		[Address(RVA = "0x1FA9D38", Offset = "0x1FA9D38", VA = "0x7BBC7A9D38", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078C9")]
		[Address(RVA = "0x1FA9D40", Offset = "0x1FA9D40", VA = "0x7BBC7A9D40", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078CA")]
		[Address(RVA = "0x1FA9D48", Offset = "0x1FA9D48", VA = "0x7BBC7A9D48", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078CB")]
		[Address(RVA = "0x1FA9D7C", Offset = "0x1FA9D7C", VA = "0x7BBC7A9D7C")]
		public UIGachaTurntableBuyBtnController()
		{
		}

		// Token: 0x04008E65 RID: 36453
		[Token(Token = "0x4008E65")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaTurntableBuyBtnView m_TurntableView;
	}
}
