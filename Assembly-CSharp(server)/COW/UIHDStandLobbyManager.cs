using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200151F RID: 5407
	[Token(Token = "0x200151F")]
	public class UIHDStandLobbyManager : MonoBehaviour, IUIModelDataChangeObserver
	{
		// Token: 0x06005CDB RID: 23771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x16AF5CC", Offset = "0x16AF5CC", VA = "0x7BBBEAF5CC", Slot = "4")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x0001B000 File Offset: 0x00019200
		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x16AF5D0", Offset = "0x16AF5D0", VA = "0x7BBBEAF5D0", Slot = "5")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0x16AF5D8", Offset = "0x16AF5D8", VA = "0x7BBBEAF5D8")]
		public UIHDStandLobbyManager()
		{
		}
	}
}
