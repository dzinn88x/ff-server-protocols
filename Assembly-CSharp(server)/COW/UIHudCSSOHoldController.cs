using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014CA RID: 5322
	[Token(Token = "0x20014CA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED91C", Offset = "0x10ED91C")]
	internal class UIHudCSSOHoldController : UIBaseController
	{
		// Token: 0x06005AAE RID: 23214 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[Token(Token = "0x6005AAE")]
		[Address(RVA = "0x19C2CD8", Offset = "0x19C2CD8", VA = "0x7BBC1C2CD8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAF")]
		[Address(RVA = "0x19C2D28", Offset = "0x19C2D28", VA = "0x7BBC1C2D28", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB0")]
		[Address(RVA = "0x19C2DF0", Offset = "0x19C2DF0", VA = "0x7BBC1C2DF0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0x19C2D50", Offset = "0x19C2D50", VA = "0x7BBC1C2D50")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0x19C2EE0", Offset = "0x19C2EE0", VA = "0x7BBC1C2EE0")]
		public UIHudCSSOHoldController()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0x19C2EE8", Offset = "0x19C2EE8", VA = "0x7BBC1C2EE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F558", Offset = "0x113F558")]
		private void <OnVisibilityChanged>b__3_0()
		{
		}

		// Token: 0x04007D85 RID: 32133
		[Token(Token = "0x4007D85")]
		[FieldOffset(Offset = "0x58")]
		private uint m_DelayCall;
	}
}
