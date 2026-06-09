using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class UVmove : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x260CAE8", Offset = "0x260CAE8", VA = "0x7BBCE0CAE8")]
	private void Start()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x260CC28", Offset = "0x260CC28", VA = "0x7BBCE0CC28")]
	private void Update()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x260CD54", Offset = "0x260CD54", VA = "0x7BBCE0CD54")]
	public UVmove()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	public int ScrollSpeed;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	public int countX;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	public int countY;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x24")]
	public int tilingX;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public int tilingY;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x2C")]
	private float offsetX;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	private float offsetY;
}
