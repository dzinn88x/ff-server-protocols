using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
internal class BountyPhaseShowOrHideGameObject : MonoBehaviour
{
	// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1F90230", Offset = "0x1F90230", VA = "0x7BBC790230")]
	private void Start()
	{
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1F90324", Offset = "0x1F90324", VA = "0x7BBC790324")]
	private void OnDestroy()
	{
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1F903E4", Offset = "0x1F903E4", VA = "0x7BBC7903E4")]
	private void OnPhaseChange(GEvent gEvent)
	{
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1F9053C", Offset = "0x1F9053C", VA = "0x7BBC79053C")]
	private bool IsInExPhases(zq|Dsh{.P{BxWi^ phaseType)
	{
		return default(bool);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1F90660", Offset = "0x1F90660", VA = "0x7BBC790660")]
	public BountyPhaseShowOrHideGameObject()
	{
	}

	// Token: 0x04000219 RID: 537
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x18")]
	public zq|Dsh{.P{BxWi^ ShowPhase;

	// Token: 0x0400021A RID: 538
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x20")]
	public List<zq|Dsh{.P{BxWi^> m_ExPhases;
}
