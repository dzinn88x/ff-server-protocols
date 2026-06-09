using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class UIPointsRaceClanItemController : UIBaseController
{
	// Token: 0x06000519 RID: 1305 RVA: 0x00002E68 File Offset: 0x00001068
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x1FC5164", Offset = "0x1FC5164", VA = "0x7BBC7C5164")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x1FC51B4", Offset = "0x1FC51B4", VA = "0x7BBC7C51B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x1FC5440", Offset = "0x1FC5440", VA = "0x7BBC7C5440", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x1FC54E8", Offset = "0x1FC54E8", VA = "0x7BBC7C54E8")]
	private void OnClickClose()
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x1FC54F0", Offset = "0x1FC54F0", VA = "0x7BBC7C54F0")]
	public void SetData(uint rewardHonorPoints, AwardDesc info, uint minPoints, bool isUnlock, bool isClaimed, bool isShowArrow, uint stageId, bool isOpen)
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x1FC5314", Offset = "0x1FC5314", VA = "0x7BBC7C5314")]
	public void UpdateView(bool isUnlock, bool isClaimed)
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x1FC56C8", Offset = "0x1FC56C8", VA = "0x7BBC7C56C8")]
	private void OnClickBox()
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x1FC60FC", Offset = "0x1FC60FC", VA = "0x7BBC7C60FC")]
	public UIPointsRaceClanItemController()
	{
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x1FC610C", Offset = "0x1FC610C", VA = "0x7BBC7C610C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E24", Offset = "0x1132E24")]
	private void <SetData>b__11_0()
	{
	}

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x58")]
	private UIPointsRaceClanItemView m_View;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x60")]
	private AwardDesc m_Info;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_TipsOffset;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x74")]
	private uint m_RewardHonorPoints;

	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x78")]
	private Animator m_BoxAnimator;

	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x80")]
	private float m_BoxAnimGapTime;

	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x84")]
	private uint m_BoxCallID;
}
