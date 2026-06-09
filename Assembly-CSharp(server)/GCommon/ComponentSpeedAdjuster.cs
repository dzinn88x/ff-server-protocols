using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F1B RID: 3867
	[Token(Token = "0x2000F1B")]
	public class ComponentSpeedAdjuster : MonoBehaviour
	{
		// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x25EC26C", Offset = "0x25EC26C", VA = "0x7BBCDEC26C")]
		private void Start()
		{
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x25ECB58", Offset = "0x25ECB58", VA = "0x7BBCDECB58")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x25ED150", Offset = "0x25ED150", VA = "0x7BBCDED150")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x25EC3D8", Offset = "0x25EC3D8", VA = "0x7BBCDEC3D8")]
		private void GetComponentsSpeed()
		{
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x25ECB94", Offset = "0x25ECB94", VA = "0x7BBCDECB94")]
		private void SetComponentsSpeed()
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x25ED15C", Offset = "0x25ED15C", VA = "0x7BBCDED15C")]
		public ComponentSpeedAdjuster()
		{
		}

		// Token: 0x040049C6 RID: 18886
		[Token(Token = "0x40049C6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112E848", Offset = "0x112E848")]
		public float m_speed;

		// Token: 0x040049C7 RID: 18887
		[Token(Token = "0x40049C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem[] m_particleSystemArray;

		// Token: 0x040049C8 RID: 18888
		[Token(Token = "0x40049C8")]
		[FieldOffset(Offset = "0x28")]
		private float[] m_particleSystemSpeed;

		// Token: 0x040049C9 RID: 18889
		[Token(Token = "0x40049C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator[] m_animatorArray;

		// Token: 0x040049CA RID: 18890
		[Token(Token = "0x40049CA")]
		[FieldOffset(Offset = "0x38")]
		private float[] m_animatorSpeed;

		// Token: 0x040049CB RID: 18891
		[Token(Token = "0x40049CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animation[] m_animationArray;

		// Token: 0x040049CC RID: 18892
		[Token(Token = "0x40049CC")]
		[FieldOffset(Offset = "0x48")]
		private float[] m_animationSpeed;

		// Token: 0x040049CD RID: 18893
		[Token(Token = "0x40049CD")]
		[FieldOffset(Offset = "0x50")]
		private List<List<AnimationState>> m_animationSateList;

		// Token: 0x040049CE RID: 18894
		[Token(Token = "0x40049CE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TrailRenderer[] m_trailRendererArray;

		// Token: 0x040049CF RID: 18895
		[Token(Token = "0x40049CF")]
		[FieldOffset(Offset = "0x60")]
		private float[] m_trailRendererSpeed;

		// Token: 0x040049D0 RID: 18896
		[Token(Token = "0x40049D0")]
		[FieldOffset(Offset = "0x68")]
		private float m_currentSpeedScale;

		// Token: 0x040049D1 RID: 18897
		[Token(Token = "0x40049D1")]
		[FieldOffset(Offset = "0x6C")]
		private float m_lastSpeedScale;
	}
}
