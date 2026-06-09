using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public class LevelPhotograph : MonoBehaviour
{
	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2520F80", Offset = "0x2520F80", VA = "0x7BBCD20F80")]
	private void Start()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x252113C", Offset = "0x252113C", VA = "0x7BBCD2113C")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x25212A8", Offset = "0x25212A8", VA = "0x7BBCD212A8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x25213E4", Offset = "0x25213E4", VA = "0x7BBCD213E4")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x252151C", Offset = "0x252151C", VA = "0x7BBCD2151C")]
	private void EnterPhotographMode(params object[] data)
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2521734", Offset = "0x2521734", VA = "0x7BBCD21734")]
	private void ExitPhotographMode(params object[] data)
	{
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x25219F8", Offset = "0x25219F8", VA = "0x7BBCD219F8")]
	private void Update()
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2521DAC", Offset = "0x2521DAC", VA = "0x7BBCD21DAC")]
	private void AdjustCameraFOV(params object[] data)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2521CC8", Offset = "0x2521CC8", VA = "0x7BBCD21CC8")]
	private UserControlAxisData GetAxisData(int axisIndex)
	{
		return null;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2521E80", Offset = "0x2521E80", VA = "0x7BBCD21E80")]
	public LevelPhotograph()
	{
	}

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x18")]
	public float moveSpeedScale;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 XMoveRange;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 YMoveRange;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x2C")]
	public float MAX_FOV;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x30")]
	public float MIN_FOV;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x38")]
	private Camera PhotoCamera;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x40")]
	private float m_OrgFOV;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsPlayerInTrigger;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x45")]
	private bool m_IsInPhotogragphMode;
}
