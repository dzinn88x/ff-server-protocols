using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
public class BountyWaitingCutsceneManager : InGameCutsceneManager
{
	// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1F93F00", Offset = "0x1F93F00", VA = "0x7BBC793F00")]
	public new void Awake()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1F93F08", Offset = "0x1F93F08", VA = "0x7BBC793F08")]
	public void OnScenedLoaded()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1F93FA8", Offset = "0x1F93FA8", VA = "0x7BBC793FA8")]
	public void LoadCutsceneAnimPrfeb(int beginIndex, int endIndex)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1F94454", Offset = "0x1F94454", VA = "0x7BBC794454")]
	public void ClearBeforRes(int clearCutsceneIndex)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1F9471C", Offset = "0x1F9471C", VA = "0x7BBC79471C")]
	private void ClearLocalPlayerAvatarAnimclip()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1F948D8", Offset = "0x1F948D8", VA = "0x7BBC7948D8", Slot = "6")]
	public override void OnCutsceneFinish(InGameCutscene FinishedCutscene)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1F93F34", Offset = "0x1F93F34", VA = "0x7BBC793F34")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1131E04", Offset = "0x1131E04")]
	private IEnumerator DelayOneFrameChooseAvatar()
	{
		return null;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1F94A30", Offset = "0x1F94A30", VA = "0x7BBC794A30")]
	public void ChooseAvatar()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1F94A34", Offset = "0x1F94A34", VA = "0x7BBC794A34")]
	public void InitLocalPlayerAvatart()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1F94FC4", Offset = "0x1F94FC4", VA = "0x7BBC794FC4")]
	public void OnAvatarUpdateFinish()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1F951A0", Offset = "0x1F951A0", VA = "0x7BBC7951A0")]
	public void ShowOrHideCutsceneAvatarHandWeapon(bool isShow)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1F9524C", Offset = "0x1F9524C", VA = "0x7BBC79524C")]
	public void ShowOrHideCutsceneAvatarBackWeapon(bool isShow)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1F952F8", Offset = "0x1F952F8", VA = "0x7BBC7952F8")]
	private void HideOrShowPlayer(bool isShow)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1F953F8", Offset = "0x1F953F8", VA = "0x7BBC7953F8", Slot = "4")]
	public override bool PlayCutscene(int index, [Optional] Action OnCutsceneFinished)
	{
		return default(bool);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1F95714", Offset = "0x1F95714", VA = "0x7BBC795714")]
	private void PlayCutsceneAnim(Animator animator, AnimationClip clip)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1F9587C", Offset = "0x1F9587C", VA = "0x7BBC79587C", Slot = "5")]
	public override void ProcessCustsceneFinishOrStoped(InGameCutscene FinishedCutscene)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1F9595C", Offset = "0x1F9595C", VA = "0x7BBC79595C")]
	public void HideLocalPlayerAvatar()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1F95A14", Offset = "0x1F95A14", VA = "0x7BBC795A14")]
	public BountyWaitingCutsceneManager()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1F95A84", Offset = "0x1F95A84", VA = "0x7BBC795A84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131E68", Offset = "0x1131E68")]
	private void <InitLocalPlayerAvatart>b__13_0(UIStatedAvatar s)
	{
	}

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RuntimeAnimatorController LocalPlayerAnimController;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<BountyWaitingLocalPlayerCutscene> LocalPlayerCutsceneList;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action OnBuildLocalAvatarFinish;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_IsFemale;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UIMaleAvatar m_LocalPlayerAvatar;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private BountyCutsceneSwitchWeapon m_SwitchWeaponTool;

	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1864", Offset = "0x10E1864")]
	private sealed class <DelayOneFrameChooseAvatar>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1F94A04", Offset = "0x1F94A04", VA = "0x7BBC794A04")]
		[DebuggerHidden]
		public <DelayOneFrameChooseAvatar>d__11(int <>1__state)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1F95A88", Offset = "0x1F95A88", VA = "0x7BBC795A88", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1F95A8C", Offset = "0x1F95A8C", VA = "0x7BBC795A8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		private object Current
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1F95B34", Offset = "0x1F95B34", VA = "0x7BBC795B34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1F95B3C", Offset = "0x1F95B3C", VA = "0x7BBC795B3C", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		private object Current
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1F95BA4", Offset = "0x1F95BA4", VA = "0x7BBC795BA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingCutsceneManager <>4__this;
	}
}
