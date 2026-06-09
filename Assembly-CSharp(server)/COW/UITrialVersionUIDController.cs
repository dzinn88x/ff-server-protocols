using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BB9 RID: 7097
	[Token(Token = "0x2001BB9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAB64", Offset = "0x10FAB64")]
	public class UITrialVersionUIDController : UIBaseController
	{
		// Token: 0x0600995C RID: 39260 RVA: 0x000285F0 File Offset: 0x000267F0
		[Token(Token = "0x600995C")]
		[Address(RVA = "0x19F3834", Offset = "0x19F3834", VA = "0x7BBC1F3834")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995D")]
		[Address(RVA = "0x19F3884", Offset = "0x19F3884", VA = "0x7BBC1F3884", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995E")]
		[Address(RVA = "0x19F3A04", Offset = "0x19F3A04", VA = "0x7BBC1F3A04")]
		public void ChangeLableColor()
		{
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600995F")]
		[Address(RVA = "0x19F3A7C", Offset = "0x19F3A7C", VA = "0x7BBC1F3A7C")]
		public void ChangeLabelDepth(int depth)
		{
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009960")]
		[Address(RVA = "0x19F3AC4", Offset = "0x19F3AC4", VA = "0x7BBC1F3AC4")]
		public UITrialVersionUIDController()
		{
		}

		// Token: 0x0400A0B2 RID: 41138
		[Token(Token = "0x400A0B2")]
		[FieldOffset(Offset = "0x58")]
		private UITrialVersionUIDView m_View;
	}
}
