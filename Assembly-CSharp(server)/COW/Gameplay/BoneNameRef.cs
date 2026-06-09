using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002920 RID: 10528
	[Token(Token = "0x2002920")]
	public class BoneNameRef : MonoBehaviour
	{
		// Token: 0x0600E012 RID: 57362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E012")]
		[Address(RVA = "0x17C8200", Offset = "0x17C8200", VA = "0x7BBBFC8200")]
		public BoneNameRef()
		{
		}

		// Token: 0x04010F1B RID: 69403
		[Token(Token = "0x4010F1B")]
		[FieldOffset(Offset = "0x18")]
		public string BoneName;

		// Token: 0x04010F1C RID: 69404
		[Token(Token = "0x4010F1C")]
		[FieldOffset(Offset = "0x20")]
		public bool ScaleWithParent;

		// Token: 0x04010F1D RID: 69405
		[Token(Token = "0x4010F1D")]
		[FieldOffset(Offset = "0x21")]
		public bool LossyScaleWithParent;
	}
}
