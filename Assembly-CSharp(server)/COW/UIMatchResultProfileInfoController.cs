using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015FB RID: 5627
	[Token(Token = "0x20015FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF84C", Offset = "0x10EF84C")]
	internal class UIMatchResultProfileInfoController : UIBaseController
	{
		// Token: 0x0600646C RID: 25708 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		[Token(Token = "0x600646C")]
		[Address(RVA = "0x147A9B8", Offset = "0x147A9B8", VA = "0x7BBBC7A9B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646D")]
		[Address(RVA = "0x147AA08", Offset = "0x147AA08", VA = "0x7BBBC7AA08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646E")]
		[Address(RVA = "0x147AA94", Offset = "0x147AA94", VA = "0x7BBBC7AA94", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646F")]
		[Address(RVA = "0x147AB3C", Offset = "0x147AB3C", VA = "0x7BBBC7AB3C")]
		public void SetPlayerData(PlayerData player)
		{
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006470")]
		[Address(RVA = "0x147AE20", Offset = "0x147AE20", VA = "0x7BBBC7AE20")]
		public void ShowMVPFlag(bool show = true)
		{
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006471")]
		[Address(RVA = "0x147AE68", Offset = "0x147AE68", VA = "0x7BBBC7AE68")]
		public void SetIsSelf()
		{
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006472")]
		[Address(RVA = "0x147AEE0", Offset = "0x147AEE0", VA = "0x7BBBC7AEE0")]
		public UIMatchResultProfileInfoController()
		{
		}

		// Token: 0x040082E0 RID: 33504
		[Token(Token = "0x40082E0")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchResultProfileInfoView m_View;

		// Token: 0x040082E1 RID: 33505
		[Token(Token = "0x40082E1")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCall;
	}
}
