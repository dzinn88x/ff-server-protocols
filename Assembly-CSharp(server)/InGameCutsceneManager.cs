using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class InGameCutsceneManager : MonoBehaviour
{
	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x24CE778", Offset = "0x24CE778", VA = "0x7BBCCCE778")]
	protected void Awake()
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x24CE9E4", Offset = "0x24CE9E4", VA = "0x7BBCCCE9E4")]
	public void Start()
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x24CE9E8", Offset = "0x24CE9E8", VA = "0x7BBCCCE9E8")]
	private void RegisterToMatchGame()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x24CEA50", Offset = "0x24CEA50", VA = "0x7BBCCCEA50", Slot = "4")]
	public virtual bool PlayCutscene(int index, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x24CEBF4", Offset = "0x24CEBF4", VA = "0x7BBCCCEBF4")]
	public bool PlayCutscene(int index, Vector3 pos, Quaternion rot, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x24CEE1C", Offset = "0x24CEE1C", VA = "0x7BBCCCEE1C")]
	public void StopCutscene(bool isCallFinishCallback = true)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x24CEF98", Offset = "0x24CEF98", VA = "0x7BBCCCEF98", Slot = "5")]
	public virtual void ProcessCustsceneFinishOrStoped(InGameCutscene FinishedCutscene)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x24CF260", Offset = "0x24CF260", VA = "0x7BBCCCF260", Slot = "6")]
	public virtual void OnCutsceneFinish(InGameCutscene FinishedCutscene)
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x24CF388", Offset = "0x24CF388", VA = "0x7BBCCCF388")]
	public InGameCutsceneManager()
	{
	}

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<InGameCutscene> m_CutsceneList;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform KeepInSceneRoot;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action m_CurFinishCallBack;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int m_CurCutsceneIndex;
}
