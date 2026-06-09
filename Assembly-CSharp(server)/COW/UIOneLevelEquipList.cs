using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001510 RID: 5392
	[Token(Token = "0x2001510")]
	public class UIOneLevelEquipList : MonoBehaviour
	{
		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x16E13E4", Offset = "0x16E13E4", VA = "0x7BBBEE13E4")]
		public UIOneLevelEquipList()
		{
		}

		// Token: 0x04007EB5 RID: 32437
		[Token(Token = "0x4007EB5")]
		[FieldOffset(Offset = "0x18")]
		public UIGrid Grid;

		// Token: 0x04007EB6 RID: 32438
		[Token(Token = "0x4007EB6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LevelLabel;

		// Token: 0x04007EB7 RID: 32439
		[Token(Token = "0x4007EB7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LockMask;

		// Token: 0x04007EB8 RID: 32440
		[Token(Token = "0x4007EB8")]
		[FieldOffset(Offset = "0x30")]
		public List<GameObject> BonusItemLevelIcon;

		// Token: 0x04007EB9 RID: 32441
		[Token(Token = "0x4007EB9")]
		[FieldOffset(Offset = "0x38")]
		public List<GameObject> BonusItemLevelIcon2;
	}
}
