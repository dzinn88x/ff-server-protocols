using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012AF RID: 4783
	[Token(Token = "0x20012AF")]
	internal class CommonMaterialEffect : ReusableObject
	{
		// Token: 0x06004AED RID: 19181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x15FBD34", Offset = "0x15FBD34", VA = "0x7BBBDFBD34")]
		private void Start()
		{
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x15FBE80", Offset = "0x15FBE80", VA = "0x7BBBDFBE80")]
		public CommonMaterialEffect()
		{
		}

		// Token: 0x04007320 RID: 29472
		[Token(Token = "0x4007320")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Material mMaterial;
	}
}
