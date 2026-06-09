using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public class UICutsceneBlackMask : MonoBehaviour
{
	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1CA0718", Offset = "0x1CA0718", VA = "0x7BBC4A0718")]
	public void SetMaskColor(Color color)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1CA0778", Offset = "0x1CA0778", VA = "0x7BBC4A0778")]
	public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float changeDuration, float stableDuration = 0f)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1CA09D0", Offset = "0x1CA09D0", VA = "0x7BBC4A09D0")]
	private bool IsTwiceChangeAnim()
	{
		return default(bool);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1CA09E4", Offset = "0x1CA09E4", VA = "0x7BBC4A09E4")]
	private bool IsCurFadeChange()
	{
		return default(bool);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1CA0A38", Offset = "0x1CA0A38", VA = "0x7BBC4A0A38")]
	private bool IsCurLightChange()
	{
		return default(bool);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1CA0884", Offset = "0x1CA0884", VA = "0x7BBC4A0884")]
	private void InitCurChangeAnimStep()
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1CA0A8C", Offset = "0x1CA0A8C", VA = "0x7BBC4A0A8C")]
	private void Update()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1CA0A90", Offset = "0x1CA0A90", VA = "0x7BBC4A0A90")]
	private void UpdateAnim()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1CA0B48", Offset = "0x1CA0B48", VA = "0x7BBC4A0B48")]
	private void UpdateChangeAnim()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1CA0CB8", Offset = "0x1CA0CB8", VA = "0x7BBC4A0CB8")]
	private void OnChangeAnimEnd()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1CA0AE8", Offset = "0x1CA0AE8", VA = "0x7BBC4A0AE8")]
	private void UpdateStableAnim()
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1CA0D48", Offset = "0x1CA0D48", VA = "0x7BBC4A0D48")]
	private void OnStableAnimEnd()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1CA0CE4", Offset = "0x1CA0CE4", VA = "0x7BBC4A0CE4")]
	private void OnAnimFinished()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1CA0D54", Offset = "0x1CA0D54", VA = "0x7BBC4A0D54")]
	public UICutsceneBlackMask()
	{
	}

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MaskSprite;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x20")]
	private float m_AnimChangeDuration;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x24")]
	private float m_AnimStableDuration;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x28")]
	private EMaskAnimType m_AnimType;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isAnimFinsihDisableMask;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x30")]
	private float m_AnimChangeTimePass;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x34")]
	private float m_AnimStableTimePass;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x38")]
	private UICutsceneBlackMask.EAnimStep m_AnimStep;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x3C")]
	private Color m_LerpBeginAnimColor;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x4C")]
	private Color m_LerpEndAnimColor;

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	private enum EAnimStep
	{
		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		AnimStep_Finished,
		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		AnimStep_FirstChange,
		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		AnimStep_Stable,
		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		AnimStep_SecondChange
	}
}
