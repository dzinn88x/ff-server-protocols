using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001600 RID: 5632
	[Token(Token = "0x2001600")]
	public class TeleportDoorHintInfo : MonoBehaviour
	{
		// Token: 0x0600647B RID: 25723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647B")]
		[Address(RVA = "0x1B47608", Offset = "0x1B47608", VA = "0x7BBC347608")]
		public void InitData(uint uid, U` doorType, string mapGroup)
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647C")]
		[Address(RVA = "0x1B476D4", Offset = "0x1B476D4", VA = "0x7BBC3476D4")]
		public TeleportDoorHintInfo()
		{
		}

		// Token: 0x040082EF RID: 33519
		[Token(Token = "0x40082EF")]
		[FieldOffset(Offset = "0x18")]
		public uint UID;

		// Token: 0x040082F0 RID: 33520
		[Token(Token = "0x40082F0")]
		[FieldOffset(Offset = "0x1C")]
		public U` DoorType;

		// Token: 0x040082F1 RID: 33521
		[Token(Token = "0x40082F1")]
		[FieldOffset(Offset = "0x20")]
		public string MapGroup;

		// Token: 0x040082F2 RID: 33522
		[Token(Token = "0x40082F2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GroupLabel;
	}
}
