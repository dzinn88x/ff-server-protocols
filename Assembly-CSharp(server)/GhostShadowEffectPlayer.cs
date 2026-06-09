using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class GhostShadowEffectPlayer : MonoBehaviour
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x1700000A")]
	private float CurGhostTime
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2748E5C", Offset = "0x2748E5C", VA = "0x7BBCF48E5C")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600011D RID: 285 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x1700000B")]
	private float CurGhostDelta
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2748E78", Offset = "0x2748E78", VA = "0x7BBCF48E78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2748E94", Offset = "0x2748E94", VA = "0x7BBCF48E94")]
	public void InitRenderList()
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2748F74", Offset = "0x2748F74", VA = "0x7BBCF48F74")]
	public void Clear()
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2748FD4", Offset = "0x2748FD4", VA = "0x7BBCF48FD4")]
	public void PlayEffect()
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x2749030", Offset = "0x2749030", VA = "0x7BBCF49030")]
	public void StopEffect()
	{
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2749038", Offset = "0x2749038", VA = "0x7BBCF49038")]
	public void PlayEffectByDate(float ghostTime, float ghostDelta)
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x2748FDC", Offset = "0x2748FDC", VA = "0x7BBCF48FDC")]
	private void PlayInit()
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2749048", Offset = "0x2749048", VA = "0x7BBCF49048")]
	private void Update()
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x274A2A8", Offset = "0x274A2A8", VA = "0x7BBCF4A2A8")]
	private void OnOneRootFinishEffect()
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x27499F0", Offset = "0x27499F0", VA = "0x7BBCF499F0")]
	private void SpawnGhost()
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2749368", Offset = "0x2749368", VA = "0x7BBCF49368")]
	private void ActiveLastGhost()
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x274A2D8", Offset = "0x274A2D8", VA = "0x7BBCF4A2D8")]
	public void DisActiveAllEffect()
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x274A428", Offset = "0x274A428", VA = "0x7BBCF4A428")]
	public static int Compare(GhostShadowRoot r1, GhostShadowRoot r2)
	{
		return 0;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x274A46C", Offset = "0x274A46C", VA = "0x7BBCF4A46C")]
	public GhostShadowEffectPlayer()
	{
	}

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x18")]
	public float m_GhostTime;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x1C")]
	public float m_GhostDelta;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x20")]
	public Shader ghostShader;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x28")]
	public Color ghostColor;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x38")]
	public float UseLerpDeltaDistance;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x3C")]
	public float StopLerpDeltaDistance;

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x40")]
	private bool bUseRuntimeDate;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x44")]
	private float m_RuntimeGhostTime;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x48")]
	private float m_RuntIMEGhostDelta;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x50")]
	private List<Renderer> RenderList;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x58")]
	private List<GhostShadowRoot> myGhostRootList;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x60")]
	private bool isPlaying;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x64")]
	private float lastTime;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 LastPostion;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 CurPlayPostion;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x80")]
	private bool bUsingLerpPostion;

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x84")]
	private int m_SpawnedGhostNum;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x88")]
	private int m_CurActivedGhostNum;
}
