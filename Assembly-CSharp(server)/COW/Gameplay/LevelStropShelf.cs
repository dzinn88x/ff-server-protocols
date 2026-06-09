using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028AB RID: 10411
	[Token(Token = "0x20028AB")]
	public class LevelStropShelf : MonoBehaviour
	{
		// Token: 0x0600DCAF RID: 56495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAF")]
		[Address(RVA = "0x1D3FC04", Offset = "0x1D3FC04", VA = "0x7BBC53FC04")]
		public LevelStropShelf()
		{
		}

		// Token: 0x04010BD3 RID: 68563
		[Token(Token = "0x4010BD3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int StropShelfId;

		// Token: 0x04010BD4 RID: 68564
		[Token(Token = "0x4010BD4")]
		[FieldOffset(Offset = "0x20")]
		public LevelStropShelfMesh MeshTF;

		// Token: 0x04010BD5 RID: 68565
		[Token(Token = "0x4010BD5")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool MeshVisible;
	}
}
