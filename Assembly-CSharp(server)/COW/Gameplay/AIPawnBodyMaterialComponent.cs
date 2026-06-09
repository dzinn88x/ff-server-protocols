using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020029EA RID: 10730
	[Token(Token = "0x20029EA")]
	internal class AIPawnBodyMaterialComponent : MonoBehaviour
	{
		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAE")]
		public Material JLcP}WF
		{
			[Token(Token = "0x600E6B7")]
			[Address(RVA = "0x188078C", Offset = "0x188078C", VA = "0x7BBC08078C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAF")]
		public Material WfDMwQ~
		{
			[Token(Token = "0x600E6B8")]
			[Address(RVA = "0x1880794", Offset = "0x1880794", VA = "0x7BBC080794")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6B9")]
		[Address(RVA = "0x1880834", Offset = "0x1880834", VA = "0x7BBC080834")]
		private void Start()
		{
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BA")]
		[Address(RVA = "0x18808CC", Offset = "0x18808CC", VA = "0x7BBC0808CC")]
		public void ResetMaterial()
		{
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BB")]
		[Address(RVA = "0x1880970", Offset = "0x1880970", VA = "0x7BBC080970")]
		public void UpdateMaterial(\u0081}\u0082XTuu Gbf\u0082KIG)
		{
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BC")]
		[Address(RVA = "0x1880B38", Offset = "0x1880B38", VA = "0x7BBC080B38")]
		public AIPawnBodyMaterialComponent()
		{
		}

		// Token: 0x040112AC RID: 70316
		[Token(Token = "0x40112AC")]
		[FieldOffset(Offset = "0x18")]
		public Renderer m_Renderer;

		// Token: 0x040112AD RID: 70317
		[Token(Token = "0x40112AD")]
		[FieldOffset(Offset = "0x20")]
		public List<AISkillMaterial> m_SkillMaterials;

		// Token: 0x040112AE RID: 70318
		[Token(Token = "0x40112AE")]
		[FieldOffset(Offset = "0x28")]
		private Material v;
	}
}
