using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017B2 RID: 6066
	[Token(Token = "0x20017B2")]
	public class UIEquipSetSelectionLobbyController : UIEquipSetSelectionController
	{
		// Token: 0x060073FC RID: 29692 RVA: 0x00020388 File Offset: 0x0001E588
		[Token(Token = "0x60073FC")]
		[Address(RVA = "0x1E7B630", Offset = "0x1E7B630", VA = "0x7BBC67B630")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073FD")]
		[Address(RVA = "0x1E7B680", Offset = "0x1E7B680", VA = "0x7BBC67B680", Slot = "42")]
		protected override UIEquipSetItemController OpenChildContainer(Transform parent)
		{
			return null;
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FE")]
		[Address(RVA = "0x1E7B714", Offset = "0x1E7B714", VA = "0x7BBC67B714")]
		public UIEquipSetSelectionLobbyController()
		{
		}
	}
}
