using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200102C RID: 4140
	[Token(Token = "0x200102C")]
	public class UIMaskEffectSprite : UIEffectSprite
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073A")]
		public override Material material
		{
			[Token(Token = "0x6003EBB")]
			[Address(RVA = "0x202EA98", Offset = "0x202EA98", VA = "0x7BBC82EA98", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x202EE78", Offset = "0x202EE78", VA = "0x7BBC82EE78")]
		public void SetShader(Shader shd)
		{
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EBD")]
		[Address(RVA = "0x202EEAC", Offset = "0x202EEAC", VA = "0x7BBC82EEAC")]
		public UIMaskEffectSprite()
		{
		}

		// Token: 0x04004F02 RID: 20226
		[Token(Token = "0x4004F02")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		[HideInInspector]
		private Shader mShader;

		// Token: 0x04004F03 RID: 20227
		[Token(Token = "0x4004F03")]
		[FieldOffset(Offset = "0x240")]
		private Material mMaterial;

		// Token: 0x04004F04 RID: 20228
		[Token(Token = "0x4004F04")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Dictionary<int, Material>> mCachedAtlasMaterials;
	}
}
