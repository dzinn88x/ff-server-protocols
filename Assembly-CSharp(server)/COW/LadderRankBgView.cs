using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A6 RID: 9638
	[Token(Token = "0x20025A6")]
	public class LadderRankBgView : MonoBehaviour
	{
		// Token: 0x0600C65C RID: 50780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65C")]
		[Address(RVA = "0x13FE7A0", Offset = "0x13FE7A0", VA = "0x7BBBBFE7A0")]
		private void Start()
		{
		}

		// Token: 0x0600C65D RID: 50781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65D")]
		[Address(RVA = "0x13FE8EC", Offset = "0x13FE8EC", VA = "0x7BBBBFE8EC")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65E")]
		[Address(RVA = "0x13FE898", Offset = "0x13FE898", VA = "0x7BBBBFE898")]
		private void Refresh(int _currentRank)
		{
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65F")]
		[Address(RVA = "0x13FE8F4", Offset = "0x13FE8F4", VA = "0x7BBBBFE8F4")]
		private void GenerateEffect(GameObject _obj)
		{
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C660")]
		[Address(RVA = "0x13FEA50", Offset = "0x13FEA50", VA = "0x7BBBBFEA50")]
		public LadderRankBgView()
		{
		}

		// Token: 0x0400F8E5 RID: 63717
		[Token(Token = "0x400F8E5")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bronzeEffect;

		// Token: 0x0400F8E6 RID: 63718
		[Token(Token = "0x400F8E6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject sliverEffect;

		// Token: 0x0400F8E7 RID: 63719
		[Token(Token = "0x400F8E7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject goldEffect;

		// Token: 0x0400F8E8 RID: 63720
		[Token(Token = "0x400F8E8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject platinumEffect;

		// Token: 0x0400F8E9 RID: 63721
		[Token(Token = "0x400F8E9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject diamondEffect;

		// Token: 0x0400F8EA RID: 63722
		[Token(Token = "0x400F8EA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject kingEffect;

		// Token: 0x0400F8EB RID: 63723
		[Token(Token = "0x400F8EB")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_ParticleObject;
	}
}
