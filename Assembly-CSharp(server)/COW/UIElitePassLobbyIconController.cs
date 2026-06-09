using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001797 RID: 6039
	[Token(Token = "0x2001797")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F25BC", Offset = "0x10F25BC")]
	internal class UIElitePassLobbyIconController : UIBaseController
	{
		// Token: 0x060072F3 RID: 29427 RVA: 0x0001FF20 File Offset: 0x0001E120
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0x1AE88A8", Offset = "0x1AE88A8", VA = "0x7BBC2E88A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0x1AE893C", Offset = "0x1AE893C", VA = "0x7BBC2E893C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F5")]
		[Address(RVA = "0x1AE8A20", Offset = "0x1AE8A20", VA = "0x7BBC2E8A20")]
		private void OnBtnEPClick()
		{
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F6")]
		[Address(RVA = "0x1AE8B50", Offset = "0x1AE8B50", VA = "0x7BBC2E8B50")]
		public Transform GetGuideTf()
		{
			return null;
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F7")]
		[Address(RVA = "0x1AE8B90", Offset = "0x1AE8B90", VA = "0x7BBC2E8B90")]
		public UIElitePassLobbyIconController()
		{
		}

		// Token: 0x04008BBD RID: 35773
		[Token(Token = "0x4008BBD")]
		[FieldOffset(Offset = "0x58")]
		private UIElitePassLobbyIconView m_View;
	}
}
