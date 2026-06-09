using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000229 RID: 553
[Token(Token = "0x2000229")]
public class UnityThread : MonoBehaviour
{
	// Token: 0x06000B2D RID: 2861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x2610C80", Offset = "0x2610C80", VA = "0x7BBCE10C80")]
	public static void Init(bool visible = false)
	{
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x2610DF0", Offset = "0x2610DF0", VA = "0x7BBCE10DF0")]
	private void Awake()
	{
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x2610E6C", Offset = "0x2610E6C", VA = "0x7BBCE10E6C")]
	public static void RunInUpdate(Action action)
	{
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x2610FBC", Offset = "0x2610FBC", VA = "0x7BBCE10FBC")]
	private void Update()
	{
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x26112C4", Offset = "0x26112C4", VA = "0x7BBCE112C4")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x2611344", Offset = "0x2611344", VA = "0x7BBCE11344")]
	public UnityThread()
	{
	}

	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x0")]
	private static UnityThread _I;

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x8")]
	private static List<Action> _UpdateActionsPending;

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x18")]
	private List<Action> _UpdateActionsExecuting;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x10")]
	private static bool _HasUpdateActions;
}
