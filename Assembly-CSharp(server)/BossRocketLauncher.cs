using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
public class BossRocketLauncher : MonoBehaviour
{
	// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1F8E100", Offset = "0x1F8E100", VA = "0x7BBC78E100")]
	public Transform ReturnTarget()
	{
		return null;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1F8E198", Offset = "0x1F8E198", VA = "0x7BBC78E198")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1F8E388", Offset = "0x1F8E388", VA = "0x7BBC78E388")]
	public BossRocketLauncher()
	{
	}

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> AttackTargetPoint;
}
