using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[Token(Token = "0x20000C0")]
public class RunTimeEffectManager : MonoBehaviour
{
	// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x23DE178", Offset = "0x23DE178", VA = "0x7BBCBDE178")]
	private void Awake()
	{
	}

	// Token: 0x06000318 RID: 792 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x23DE5AC", Offset = "0x23DE5AC", VA = "0x7BBCBDE5AC")]
	private bool ScaleInLocalSpace(GameObject o)
	{
		return default(bool);
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000319")]
	[Address(RVA = "0x23DE6B8", Offset = "0x23DE6B8", VA = "0x7BBCBDE6B8")]
	public void InitEffectElements()
	{
	}

	// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x23DE994", Offset = "0x23DE994", VA = "0x7BBCBDE994")]
	private Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x23DEB48", Offset = "0x23DEB48", VA = "0x7BBCBDEB48")]
	public RunTimeEffectManager()
	{
	}

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x18")]
	public RunTimeEffectManager.EffectElement[] m_EffectElements;

	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[Serializable]
	public struct EffectElement
	{
		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x0")]
		public Transform m_EffectTransForm;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x8")]
		public string m_TargetRootName;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x10")]
		public string m_TargetBoneName;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x18")]
		public bool ScaleWithParent;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x20")]
		public Transform TargetTransform;
	}
}
