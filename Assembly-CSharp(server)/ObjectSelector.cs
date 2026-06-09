using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public class ObjectSelector : MonoBehaviour
{
	// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x229157C", Offset = "0x229157C", VA = "0x7BBCA9157C")]
	private void Start()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2291B64", Offset = "0x2291B64", VA = "0x7BBCA91B64")]
	private void Update()
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2291C50", Offset = "0x2291C50", VA = "0x7BBCA91C50")]
	public ObjectSelector()
	{
	}

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem activeParticle;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x20")]
	public ObjectSelector.SelectorType SelectType;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x28")]
	public List<ObjectSelector.SelectionRule> Rules;

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public enum SelectorType
	{
		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		ByMasterRank
	}

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Serializable]
	public class SelectionRule
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2291CC0", Offset = "0x2291CC0", VA = "0x7BBCA91CC0")]
		public SelectionRule()
		{
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x10")]
		public int threshold;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		public GameObject selectedObject;
	}
}
