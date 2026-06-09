using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.HUD
{
	// Token: 0x02002660 RID: 9824
	[Token(Token = "0x2002660")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE140", Offset = "0x10FE140")]
	internal class UIHudLockedTargetController : UIHudVehicleAsMissileTargetControllerBase
	{
		// Token: 0x0600CA96 RID: 51862 RVA: 0x00036798 File Offset: 0x00034998
		[Token(Token = "0x600CA96")]
		[Address(RVA = "0x1769944", Offset = "0x1769944", VA = "0x7BBBF69944")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA97")]
		[Address(RVA = "0x1769994", Offset = "0x1769994", VA = "0x7BBBF69994", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA98")]
		[Address(RVA = "0x1769AB8", Offset = "0x1769AB8", VA = "0x7BBBF69AB8")]
		public UIHudLockedTargetController()
		{
		}

		// Token: 0x0400FF1A RID: 65306
		[Token(Token = "0x400FF1A")]
		[FieldOffset(Offset = "0xF0")]
		private UIHudLockedTargetView p|r\u007Fnuf;
	}
}
