using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009A RID: 154
[Token(Token = "0x200009A")]
public class BountyTimeLineSubtitleController : MonoBehaviour
{
	// Token: 0x06000223 RID: 547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1F91FA4", Offset = "0x1F91FA4", VA = "0x7BBC791FA4")]
	private void Awake()
	{
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1F91FD8", Offset = "0x1F91FD8", VA = "0x7BBC791FD8")]
	private void OnEnable()
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1F92004", Offset = "0x1F92004", VA = "0x7BBC792004")]
	private void Update()
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1F920FC", Offset = "0x1F920FC", VA = "0x7BBC7920FC")]
	public BountyTimeLineSubtitleController()
	{
	}

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x18")]
	public float BeginTime;

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x1C")]
	public float ShowDuration;

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ShowRoot;

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x28")]
	private float m_ActiveTime;

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ShowedTime;
}
