using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class BountyWaitingCutsceneSkip : MonoBehaviour
{
	// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1F95BAC", Offset = "0x1F95BAC", VA = "0x7BBC795BAC")]
	private void Awake()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1F95BE0", Offset = "0x1F95BE0", VA = "0x7BBC795BE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1F95C0C", Offset = "0x1F95C0C", VA = "0x7BBC795C0C")]
	private void Update()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1F95D0C", Offset = "0x1F95D0C", VA = "0x7BBC795D0C")]
	public void SkipCutscene()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1F95DF4", Offset = "0x1F95DF4", VA = "0x7BBC795DF4")]
	public BountyWaitingCutsceneSkip()
	{
	}

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x18")]
	public float BeginTime;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x1C")]
	public float ShowDuration;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ShowRoot;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x28")]
	private float m_ActiveTime;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ShowedTime;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsClosed;
}
