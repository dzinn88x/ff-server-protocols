using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x10E1B6C", Offset = "0x10E1B6C")]
public class EnvWeatherController : MonoBehaviour
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000012")]
	public static EnvWeatherController instance
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x23F5FF4", Offset = "0x23F5FF4", VA = "0x7BBCBF5FF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113214C", Offset = "0x113214C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x23F6044", Offset = "0x23F6044", VA = "0x7BBCBF6044")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113215C", Offset = "0x113215C")]
		private set
		{
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000013")]
	public EnvWeatherPreset currentPreset
	{
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x23F6098", Offset = "0x23F6098", VA = "0x7BBCBF6098")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113216C", Offset = "0x113216C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x23F60A0", Offset = "0x23F60A0", VA = "0x7BBCBF60A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113217C", Offset = "0x113217C")]
		private set
		{
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000014")]
	public EnvWeatherPreset targetPreset
	{
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x23F60A8", Offset = "0x23F60A8", VA = "0x7BBCBF60A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113218C", Offset = "0x113218C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x23F60B0", Offset = "0x23F60B0", VA = "0x7BBCBF60B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113219C", Offset = "0x113219C")]
		private set
		{
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public event EnvWeatherController.OnWeatherChanged onWeatherChanged
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x23F60B8", Offset = "0x23F60B8", VA = "0x7BBCBF60B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11321AC", Offset = "0x11321AC")]
		add
		{
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x23F61A4", Offset = "0x23F61A4", VA = "0x7BBCBF61A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11321BC", Offset = "0x11321BC")]
		remove
		{
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000015")]
	public List<ResourceID> footStepSounds
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x23F6290", Offset = "0x23F6290", VA = "0x7BBCBF6290")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x23F6298", Offset = "0x23F6298", VA = "0x7BBCBF6298")]
	private void Awake()
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x23F64AC", Offset = "0x23F64AC", VA = "0x7BBCBF64AC")]
	private void OnEnable()
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x23F64B0", Offset = "0x23F64B0", VA = "0x7BBCBF64B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x23F6970", Offset = "0x23F6970", VA = "0x7BBCBF6970")]
	private void Start()
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x23F6A68", Offset = "0x23F6A68", VA = "0x7BBCBF6A68")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x23F6BF0", Offset = "0x23F6BF0", VA = "0x7BBCBF6BF0")]
	private void Update()
	{
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x23F74A4", Offset = "0x23F74A4", VA = "0x7BBCBF74A4")]
	private GameObject GetResourceByName(string name)
	{
		return null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x23F6D10", Offset = "0x23F6D10", VA = "0x7BBCBF6D10")]
	private bool UnderShelterCheck(Player player, bool playerInRoom)
	{
		return default(bool);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x23F6F28", Offset = "0x23F6F28", VA = "0x7BBCBF6F28")]
	private void UpdateEffectTransform(Transform followTrans, bool playerUnderShelter)
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x23F7354", Offset = "0x23F7354", VA = "0x7BBCBF7354")]
	private void UpdateAudio(bool playerInRoom)
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x23F7844", Offset = "0x23F7844", VA = "0x7BBCBF7844")]
	public void SetZoneInRoom(bool zoneInRoom)
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x23F7850", Offset = "0x23F7850", VA = "0x7BBCBF7850")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11321CC", Offset = "0x11321CC")]
	public IEnumerator TweenWeather(EnvWeatherPreset preset, float duration)
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x23F7930", Offset = "0x23F7930", VA = "0x7BBCBF7930")]
	private void TriggerWeatherChangedEvent()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x23F81F4", Offset = "0x23F81F4", VA = "0x7BBCBF81F4")]
	public void UpdateWeatherParameters(EnvWeatherPreset preset)
	{
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x23F653C", Offset = "0x23F653C", VA = "0x7BBCBF653C")]
	public void SetWeather(EnvWeatherPreset preset)
	{
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x23F7640", Offset = "0x23F7640", VA = "0x7BBCBF7640")]
	private bool PlayEnvSound(string soundLoopName, float volume)
	{
		return default(bool);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000193")]
	[Address(RVA = "0x23F89AC", Offset = "0x23F89AC", VA = "0x7BBCBF89AC")]
	private void StopCurrentEnvSound()
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x23F8794", Offset = "0x23F8794", VA = "0x7BBCBF8794")]
	private void UpdateFootstepsSound(EnvWeatherSound soundpreset)
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x23F8A90", Offset = "0x23F8A90", VA = "0x7BBCBF8A90")]
	private bool IsSkyboxTheSame(EnvSkybox lhs, EnvSkybox rhs)
	{
		return default(bool);
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x23F8B80", Offset = "0x23F8B80", VA = "0x7BBCBF8B80")]
	public EnvSkybox GetWeatherSkybox()
	{
		return null;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x23F8D84", Offset = "0x23F8D84", VA = "0x7BBCBF8D84")]
	public EnvGlobalSetting GetWeatherGlobalSetting()
	{
		return null;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x23F8F28", Offset = "0x23F8F28", VA = "0x7BBCBF8F28")]
	private void LerpGlobalSetting(EnvGlobalSetting previousSetting, EnvGlobalSetting targetSetting, float ratio)
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x23F8724", Offset = "0x23F8724", VA = "0x7BBCBF8724")]
	public float GetEmissionRate(ParticleSystem sys)
	{
		return 0f;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x23F9238", Offset = "0x23F9238", VA = "0x7BBCBF9238")]
	public void SetEmissionRate(ParticleSystem sys, float emissionRate)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x23F92D0", Offset = "0x23F92D0", VA = "0x7BBCBF92D0")]
	private void OnRecvWeatherChanged(params object[] param)
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x23F95E4", Offset = "0x23F95E4", VA = "0x7BBCBF95E4")]
	public void TriggerWeatherEvent(string weatherName, float duration)
	{
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x23F9464", Offset = "0x23F9464", VA = "0x7BBCBF9464")]
	public void TriggerWeatherEvent(int weatherIndex, float duration)
	{
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x23F96C4", Offset = "0x23F96C4", VA = "0x7BBCBF96C4")]
	public EnvWeatherController()
	{
	}

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFBF0", Offset = "0x10FFBF0")]
	private static EnvWeatherController <instance>k__BackingField;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x18")]
	public List<string> weatherEventNames;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x20")]
	public List<EnvWeatherPreset> weatherPresets;

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x28")]
	public EnvWeatherPreset defaultPreset;

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFC00", Offset = "0x10FFC00")]
	private EnvWeatherPreset <currentPreset>k__BackingField;

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFC10", Offset = "0x10FFC10")]
	private EnvWeatherPreset <targetPreset>k__BackingField;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x48")]
	private Light mainLight;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x50")]
	private LensFlare lensFlare;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x58")]
	private Material skyboxMaterial;

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x60")]
	private GameObject effectHolder;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x68")]
	private Transform camTrans;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x70")]
	private bool m_zoneInRoom;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x71")]
	private bool m_playerInRoom;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x72")]
	private bool m_playerUnderShelter;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x74")]
	private float m_shelterCheckTime;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x78")]
	private MDsfkBx m_Tmpinfo;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	private const float shelterCheckInterval = 0.333f;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x80")]
	public List<ParticleSystem> particles;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x88")]
	private List<float> particleEmissionRates;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x90")]
	private AudioResource currentAudio;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x98")]
	private List<ResourceID> m_footStepSounds;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0xA0")]
	private Shader skyboxShader;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0xA8")]
	private Shader skyboxBlendedShader;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0xB0")]
	private IEnumerator weatherTweener;

	// Token: 0x0200007C RID: 124
	// (Invoke) Token: 0x060001A0 RID: 416
	[Token(Token = "0x200007C")]
	public delegate void OnWeatherChanged(string weatherName);

	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1BE0", Offset = "0x10E1BE0")]
	private sealed class <TweenWeather>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x23F7904", Offset = "0x23F7904", VA = "0x7BBCBF7904")]
		[DebuggerHidden]
		public <TweenWeather>d__50(int <>1__state)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x23F9800", Offset = "0x23F9800", VA = "0x7BBCBF9800", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x23F9804", Offset = "0x23F9804", VA = "0x7BBCBF9804", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		private object Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x23FA688", Offset = "0x23FA688", VA = "0x7BBCBFA688", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x23FA690", Offset = "0x23FA690", VA = "0x7BBCBFA690", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		private object Current
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x23FA6F8", Offset = "0x23FA6F8", VA = "0x7BBCBFA6F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x20")]
		public EnvWeatherController <>4__this;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x28")]
		public EnvWeatherPreset preset;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x34")]
		private bool <hasSound>5__2;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x35")]
		private bool <soundChanged>5__3;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x38")]
		private float <tweenTime>5__4;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x3C")]
		private bool <footstepsSoundUpdated>5__5;
	}
}
