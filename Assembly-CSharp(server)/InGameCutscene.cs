using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class InGameCutscene : MonoBehaviour
{
	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x24CD014", Offset = "0x24CD014", VA = "0x7BBCCCD014")]
	private void Awake()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x24CD098", Offset = "0x24CD098", VA = "0x7BBCCCD098")]
	public void LoadAnimPrefeb()
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x24CD3FC", Offset = "0x24CD3FC", VA = "0x7BBCCCD3FC")]
	public void UnLoadAnimPrefeb()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x24CD580", Offset = "0x24CD580", VA = "0x7BBCCCD580")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x24CD584", Offset = "0x24CD584", VA = "0x7BBCCCD584")]
	public void PlayCutscene()
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x24CD5D4", Offset = "0x24CD5D4", VA = "0x7BBCCCD5D4")]
	private void ReCalculateCutsceneTime()
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x24CD9E4", Offset = "0x24CD9E4", VA = "0x7BBCCCD9E4")]
	public void OnCutsceneFinish()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x24CDA1C", Offset = "0x24CDA1C", VA = "0x7BBCCCDA1C")]
	public void StopCutscene()
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x24CE4B0", Offset = "0x24CE4B0", VA = "0x7BBCCCE4B0")]
	private void Update()
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x24CD788", Offset = "0x24CD788", VA = "0x7BBCCCD788")]
	private void OnCutsceneBegin()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x24CE3E8", Offset = "0x24CE3E8", VA = "0x7BBCCCE3E8")]
	private void NotifyLocalplayerInCutscene(bool isInCutscene)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x24CE518", Offset = "0x24CE518", VA = "0x7BBCCCE518", Slot = "4")]
	public virtual void UpdateBlackMask()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x24CE690", Offset = "0x24CE690", VA = "0x7BBCCCE690")]
	public InGameCutscene()
	{
	}

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x18")]
	public bool IsLoop;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x1C")]
	public float m_TotalTime;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x20")]
	public Animator TimeLineAnimator;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x28")]
	public bool IsUseCutsceneCamera;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x29")]
	public bool m_IsHideHUD;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_AnimPrefab;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x38")]
	public bool m_IsFinishDestory;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> m_GameObjectKeepInScene;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF86C", Offset = "0x10FF86C")]
	public List<BlackMaskConfig> m_BlackMaskConfig;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FF8A4", Offset = "0x10FF8A4")]
	public string AnimPrefebResourceID;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x58")]
	public InGameCutscene.OnFinished deleg_OnFinished;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasBegun;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x64")]
	private float m_BeginPlayTime;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x68")]
	private UICutsceneBlackMask m_BlackMaskUI;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x70")]
	private int curBlackMaskIndex;

	// Token: 0x02000019 RID: 25
	// (Invoke) Token: 0x0600005C RID: 92
	[Token(Token = "0x2000019")]
	public delegate void OnFinished(InGameCutscene cutscene);
}
