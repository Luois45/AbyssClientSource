using System;
using System.IO;
using Newtonsoft.Json;
using ns163;

namespace ns75
{
	// Token: 0x02000054 RID: 84
	public class GClass40
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0000A0A8 File Offset: 0x000082A8
		internal static void smethod_0()
		{
			GClass40.smethod_8();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000A0BC File Offset: 0x000082BC
		internal static void smethod_1()
		{
			GClass40.smethod_5();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000A0D0 File Offset: 0x000082D0
		internal static void smethod_2()
		{
			GClass40.smethod_0();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000A0E4 File Offset: 0x000082E4
		internal static void smethod_3()
		{
			if (GClass40.gclass40_0 != null)
			{
				File.WriteAllText(GClass40.string_0 + "//" + "config.json", JsonConvert.SerializeObject(GClass40.gclass40_0, 1));
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000A484 File Offset: 0x00008684
		internal static void smethod_4()
		{
			GClass40.smethod_7();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000A498 File Offset: 0x00008698
		internal static void smethod_5()
		{
			GClass40.smethod_3();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000A4AC File Offset: 0x000086AC
		internal static void smethod_6()
		{
			GClass40.smethod_4();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000A4C0 File Offset: 0x000086C0
		internal static void smethod_7()
		{
			Directory.CreateDirectory(GClass40.string_0);
			if (!File.Exists(GClass40.string_0 + "//" + "config.json"))
			{
				GClass40.gclass40_0 = new GClass40();
				GClass40.smethod_1();
			}
			else
			{
				GClass40.gclass40_0 = JsonConvert.DeserializeObject<GClass40>(File.ReadAllText(GClass40.string_0 + "//" + "config.json"));
				if (GClass40.gclass40_0 == null)
				{
					GClass40.gclass40_0 = new GClass40();
				}
				GClass40.smethod_1();
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000A544 File Offset: 0x00008744
		internal static void smethod_8()
		{
			if (GClass40.gclass40_0 != null)
			{
				GClass63.smethod_1(GClass40.gclass40_0);
			}
		}

		// Token: 0x0400015E RID: 350
		internal static string string_0 = Path.Combine(Environment.CurrentDirectory, "_Unreal/AntiCrash");

		// Token: 0x0400015F RID: 351
		internal static GClass40 gclass40_0;

		// Token: 0x04000160 RID: 352
		[JsonProperty("bEnableAntiCrash")]
		public bool bool_0 = true;

		// Token: 0x04000161 RID: 353
		[JsonProperty("bEnableAntiCrash_Preliminary")]
		public bool bool_1 = true;

		// Token: 0x04000162 RID: 354
		[JsonProperty("bDisablePatches")]
		public bool bool_2 = false;

		// Token: 0x04000163 RID: 355
		[JsonProperty("bUseFastCheck")]
		public bool bool_3 = true;

		// Token: 0x04000164 RID: 356
		[JsonProperty("bIgnoreCheckingSelf")]
		public bool bool_4 = false;

		// Token: 0x04000165 RID: 357
		[JsonProperty("bIgnoreCheckingFriends")]
		public bool bool_5 = false;

		// Token: 0x04000166 RID: 358
		[JsonProperty("bAbideByShowAvatar")]
		public bool bool_6 = false;

		// Token: 0x04000167 RID: 359
		[JsonProperty("bLogAntiCrash")]
		public bool bool_7 = true;

		// Token: 0x04000168 RID: 360
		[JsonProperty("bIgnoreLoggingSelf_AntiCrash")]
		public bool bool_8 = true;

		// Token: 0x04000169 RID: 361
		[JsonProperty("bLogSteps")]
		public bool bool_9 = false;

		// Token: 0x0400016A RID: 362
		[JsonProperty("bUseColorsForNicknames")]
		public bool bool_10 = true;

		// Token: 0x0400016B RID: 363
		[JsonProperty("bLogAvatarsPatches")]
		public bool bool_11 = false;

		// Token: 0x0400016C RID: 364
		[JsonProperty("bFullCheckInPreliminaryCheck")]
		public bool bool_12 = true;

		// Token: 0x0400016D RID: 365
		[JsonProperty("bUseMaterialLimiter")]
		public bool bool_13 = true;

		// Token: 0x0400016E RID: 366
		[JsonProperty("bIgnoreCheckingSelf_Materials")]
		public bool bool_14 = false;

		// Token: 0x0400016F RID: 367
		[JsonProperty("bIgnoreCheckingFriends_Materials")]
		public bool bool_15 = false;

		// Token: 0x04000170 RID: 368
		[JsonProperty("bLogMaterialLimiter")]
		public bool bool_16 = true;

		// Token: 0x04000171 RID: 369
		[JsonProperty("bIgnoreLoggingSelf_Material")]
		public bool bool_17 = false;

		// Token: 0x04000172 RID: 370
		[JsonProperty("bUseBlackListShaders")]
		public bool bool_18 = false;

		// Token: 0x04000173 RID: 371
		[JsonProperty("bUseWhiteListShaders")]
		public bool bool_19 = true;

		// Token: 0x04000174 RID: 372
		[JsonProperty("bBlockCustomShaders")]
		public bool bool_20 = false;

		// Token: 0x04000175 RID: 373
		[JsonProperty("bIgnoreCheckingSelf_Shaders")]
		public bool bool_21 = false;

		// Token: 0x04000176 RID: 374
		[JsonProperty("bIgnoreCheckingFriends_Shaders")]
		public bool bool_22 = false;

		// Token: 0x04000177 RID: 375
		[JsonProperty("bLogBlackListShaders")]
		public bool bool_23 = true;

		// Token: 0x04000178 RID: 376
		[JsonProperty("bLogWhiteListShaders")]
		public bool bool_24 = true;

		// Token: 0x04000179 RID: 377
		[JsonProperty("bLogCustomShaders")]
		public bool bool_25 = true;

		// Token: 0x0400017A RID: 378
		[JsonProperty("bIgnoreLoggingSelf_Shaders")]
		public bool bool_26 = false;

		// Token: 0x0400017B RID: 379
		[JsonProperty("bSaveShaders")]
		public bool bool_27 = true;

		// Token: 0x0400017C RID: 380
		[JsonProperty("bFixTextureAfterChangingShader")]
		public bool bool_28 = true;

		// Token: 0x0400017D RID: 381
		[JsonProperty("bRemoveSimilarObjects")]
		public bool bool_29 = true;

		// Token: 0x0400017E RID: 382
		[JsonProperty("bIgnoreCheckingSelf_SimilarObjects")]
		public bool bool_30 = false;

		// Token: 0x0400017F RID: 383
		[JsonProperty("bIgnoreCheckingFriends_SimilarObjects")]
		public bool bool_31 = false;

		// Token: 0x04000180 RID: 384
		[JsonProperty("bRemoveSimilarObjects_UseSmartSearch_TwoSteps")]
		public bool bool_32 = true;

		// Token: 0x04000181 RID: 385
		[JsonProperty("bRemoveSimilarObjects_UseSmartSearch_Fast")]
		public bool bool_33 = true;

		// Token: 0x04000182 RID: 386
		[JsonProperty("bRemoveSimilarObjects_UseSmartSearch")]
		public bool bool_34 = true;

		// Token: 0x04000183 RID: 387
		[JsonProperty("bRemoveSimilarObjects_IgnoreMultiMaterial")]
		public bool bool_35 = true;

		// Token: 0x04000184 RID: 388
		[JsonProperty("bLogSimilarObjects")]
		public bool bool_36 = true;

		// Token: 0x04000185 RID: 389
		[JsonProperty("bIgnoreLoggingSelf_SimilarObjects")]
		public bool bool_37 = false;

		// Token: 0x04000186 RID: 390
		[JsonProperty("bRemoveColliders")]
		public bool bool_38 = false;

		// Token: 0x04000187 RID: 391
		[JsonProperty("bIgnoreCheckingSelf_Colliders")]
		public bool bool_39 = false;

		// Token: 0x04000188 RID: 392
		[JsonProperty("bIgnoreCheckingFriends_Colliders")]
		public bool bool_40 = false;

		// Token: 0x04000189 RID: 393
		[JsonProperty("bLogColliders")]
		public bool bool_41 = true;

		// Token: 0x0400018A RID: 394
		[JsonProperty("bIgnoreLoggingSelf_Colliders")]
		public bool bool_42 = false;

		// Token: 0x0400018B RID: 395
		[JsonProperty("bRemoveUselessComponents")]
		public bool bool_43 = true;

		// Token: 0x0400018C RID: 396
		[JsonProperty("bIgnoreCheckingSelf_UselessComponents")]
		public bool bool_44 = false;

		// Token: 0x0400018D RID: 397
		[JsonProperty("bIgnoreCheckingFriends_UselessComponents")]
		public bool bool_45 = false;

		// Token: 0x0400018E RID: 398
		[JsonProperty("bLogUselessComponents")]
		public bool bool_46 = true;

		// Token: 0x0400018F RID: 399
		[JsonProperty("bIgnoreLoggingSelf_UselessComponents")]
		public bool bool_47 = false;

		// Token: 0x04000190 RID: 400
		[JsonProperty("bRemoveIdenticalComponents")]
		public bool bool_48 = true;

		// Token: 0x04000191 RID: 401
		[JsonProperty("bIgnoreCheckingSelf_IdenticalComponents")]
		public bool bool_49 = false;

		// Token: 0x04000192 RID: 402
		[JsonProperty("bIgnoreCheckingFriends_IdenticalComponents")]
		public bool bool_50 = false;

		// Token: 0x04000193 RID: 403
		[JsonProperty("bLogIdenticalComponents")]
		public bool bool_51 = true;

		// Token: 0x04000194 RID: 404
		[JsonProperty("bIgnoreLoggingSelf_IdenticalComponents")]
		public bool bool_52 = false;

		// Token: 0x04000195 RID: 405
		[JsonProperty("bLogIdenticalComponents_Full")]
		public bool bool_53 = false;

		// Token: 0x04000196 RID: 406
		[JsonProperty("bUseParticleLimiter")]
		public bool bool_54 = true;

		// Token: 0x04000197 RID: 407
		[JsonProperty("bIgnoreCheckingSelf_Particles")]
		public bool bool_55 = false;

		// Token: 0x04000198 RID: 408
		[JsonProperty("bIgnoreCheckingFriends_Particles")]
		public bool bool_56 = false;

		// Token: 0x04000199 RID: 409
		[JsonProperty("bLogParticleLimiter")]
		public bool bool_57 = true;

		// Token: 0x0400019A RID: 410
		[JsonProperty("bIgnoreLoggingSelf_Particles")]
		public bool bool_58 = false;

		// Token: 0x0400019B RID: 411
		[JsonProperty("LimitParticle_MaxSystems")]
		public int int_0 = 500;

		// Token: 0x0400019C RID: 412
		[JsonProperty("bUseLightLimiter")]
		public bool bool_59 = true;

		// Token: 0x0400019D RID: 413
		[JsonProperty("bIgnoreCheckingSelf_Lights")]
		public bool bool_60 = false;

		// Token: 0x0400019E RID: 414
		[JsonProperty("bIgnoreCheckingFriends_Lights")]
		public bool bool_61 = false;

		// Token: 0x0400019F RID: 415
		[JsonProperty("bLogLightLimiter")]
		public bool bool_62 = true;

		// Token: 0x040001A0 RID: 416
		[JsonProperty("bIgnoreLoggingSelf_Lights")]
		public bool bool_63 = false;

		// Token: 0x040001A1 RID: 417
		[JsonProperty("bRemoveUselessObjects")]
		public bool bool_64 = true;

		// Token: 0x040001A2 RID: 418
		[JsonProperty("bIgnoreCheckingSelf_UselessObjects")]
		public bool bool_65 = false;

		// Token: 0x040001A3 RID: 419
		[JsonProperty("bIgnoreCheckingFriends_UselessObjects")]
		public bool bool_66 = false;

		// Token: 0x040001A4 RID: 420
		[JsonProperty("bLogUselessObjects")]
		public bool bool_67 = true;

		// Token: 0x040001A5 RID: 421
		[JsonProperty("bIgnoreLoggingSelf_UselessObjects")]
		public bool bool_68 = false;

		// Token: 0x040001A6 RID: 422
		[JsonProperty("bLogUselessObjects_Full")]
		public bool bool_69 = false;

		// Token: 0x040001A7 RID: 423
		[JsonProperty("bUseMeshLimiter")]
		public bool bool_70 = true;

		// Token: 0x040001A8 RID: 424
		[JsonProperty("bIgnoreCheckingSelf_Meshes")]
		public bool bool_71 = false;

		// Token: 0x040001A9 RID: 425
		[JsonProperty("bIgnoreCheckingFriends_Meshes")]
		public bool bool_72 = false;

		// Token: 0x040001AA RID: 426
		[JsonProperty("bLogMeshLimiter")]
		public bool bool_73 = true;

		// Token: 0x040001AB RID: 427
		[JsonProperty("bIgnoreLoggingSelf_Meshes")]
		public bool bool_74 = false;

		// Token: 0x040001AC RID: 428
		[JsonProperty("bUseChildrenLimiter")]
		public bool bool_75 = true;

		// Token: 0x040001AD RID: 429
		[JsonProperty("bIgnoreCheckingSelf_ChildrenLimiter")]
		public bool bool_76 = false;

		// Token: 0x040001AE RID: 430
		[JsonProperty("bIgnoreCheckingFriends_ChildrenLimiter")]
		public bool bool_77 = false;

		// Token: 0x040001AF RID: 431
		[JsonProperty("bLogChildrenLimiter")]
		public bool bool_78 = true;

		// Token: 0x040001B0 RID: 432
		[JsonProperty("bIgnoreLoggingSelf_ChildrenLimiter")]
		public bool bool_79 = false;

		// Token: 0x040001B1 RID: 433
		[JsonProperty("bUseDynamicBonesLimiter")]
		public bool bool_80 = true;

		// Token: 0x040001B2 RID: 434
		[JsonProperty("bIgnoreCheckingSelf_DynamicBonesLimiter")]
		public bool bool_81 = false;

		// Token: 0x040001B3 RID: 435
		[JsonProperty("bIgnoreCheckingFriends_DynamicBonesLimiter")]
		public bool bool_82 = false;

		// Token: 0x040001B4 RID: 436
		[JsonProperty("bLogDynamicBonesLimiter")]
		public bool bool_83 = true;

		// Token: 0x040001B5 RID: 437
		[JsonProperty("bIgnoreLoggingSelf_DynamicBonesLimiter")]
		public bool bool_84 = false;

		// Token: 0x040001B6 RID: 438
		[JsonProperty("bUseClothsLimiter")]
		public bool bool_85 = true;

		// Token: 0x040001B7 RID: 439
		[JsonProperty("bIgnoreCheckingSelf_ClothsLimiter")]
		public bool bool_86 = false;

		// Token: 0x040001B8 RID: 440
		[JsonProperty("bIgnoreCheckingFriends_ClothsLimiter")]
		public bool bool_87 = false;

		// Token: 0x040001B9 RID: 441
		[JsonProperty("bLogClothsLimiter")]
		public bool bool_88 = true;

		// Token: 0x040001BA RID: 442
		[JsonProperty("bIgnoreLoggingSelf_ClothsLimiter")]
		public bool bool_89 = false;

		// Token: 0x040001BB RID: 443
		[JsonProperty("bUseFinalIKLimiter")]
		public bool bool_90 = true;

		// Token: 0x040001BC RID: 444
		[JsonProperty("bIgnoreCheckingSelf_FinalIKLimiter")]
		public bool bool_91 = false;

		// Token: 0x040001BD RID: 445
		[JsonProperty("bIgnoreCheckingFriends_FinalIKLimiter")]
		public bool bool_92 = false;

		// Token: 0x040001BE RID: 446
		[JsonProperty("bLogFinalIKLimiter")]
		public bool bool_93 = true;

		// Token: 0x040001BF RID: 447
		[JsonProperty("bIgnoreLoggingSelf_FinalIKLimiter")]
		public bool bool_94 = false;

		// Token: 0x040001C0 RID: 448
		[JsonProperty("bUseChildrenGenerationLimiter")]
		public bool bool_95 = true;

		// Token: 0x040001C1 RID: 449
		[JsonProperty("bIgnoreCheckingSelf_ChildrenGenerationLimiter")]
		public bool bool_96 = false;

		// Token: 0x040001C2 RID: 450
		[JsonProperty("bIgnoreCheckingFriends_ChildrenGenerationLimiter")]
		public bool bool_97 = false;

		// Token: 0x040001C3 RID: 451
		[JsonProperty("bLogChildrenGenerationLimiter")]
		public bool bool_98 = true;

		// Token: 0x040001C4 RID: 452
		[JsonProperty("bIgnoreLoggingSelf_ChildrenGenerationLimiter")]
		public bool bool_99 = false;

		// Token: 0x040001C5 RID: 453
		[JsonProperty("bUseObjectLimiter")]
		public bool bool_100 = true;

		// Token: 0x040001C6 RID: 454
		[JsonProperty("bIgnoreCheckingSelf_ObjectLimiter")]
		public bool bool_101 = false;

		// Token: 0x040001C7 RID: 455
		[JsonProperty("bIgnoreCheckingFriends_ObjectLimiter")]
		public bool bool_102 = false;

		// Token: 0x040001C8 RID: 456
		[JsonProperty("bLogObjectLimiter")]
		public bool bool_103 = true;

		// Token: 0x040001C9 RID: 457
		[JsonProperty("bIgnoreLoggingSelf_ObjectLimiter")]
		public bool bool_104 = false;

		// Token: 0x040001CA RID: 458
		[JsonProperty("bUseObjectNameLimiter")]
		public bool bool_105 = true;

		// Token: 0x040001CB RID: 459
		[JsonProperty("bIgnoreCheckingSelf_ObjectNameLimiter")]
		public bool bool_106 = false;

		// Token: 0x040001CC RID: 460
		[JsonProperty("bIgnoreCheckingFriends_ObjectNameLimiter")]
		public bool bool_107 = false;

		// Token: 0x040001CD RID: 461
		[JsonProperty("bLogObjectNameLimiter")]
		public bool bool_108 = true;

		// Token: 0x040001CE RID: 462
		[JsonProperty("bIgnoreLoggingSelf_ObjectNameLimiter")]
		public bool bool_109 = false;

		// Token: 0x040001CF RID: 463
		[JsonProperty("MaxLinesOfLog")]
		public int int_1 = 3000;

		// Token: 0x040001D0 RID: 464
		[JsonProperty("bLogDestroyedObjects")]
		public bool bool_110 = true;

		// Token: 0x040001D1 RID: 465
		[JsonProperty("bIncludeFriendsInHides")]
		public bool bool_111 = true;

		// Token: 0x040001D2 RID: 466
		[JsonProperty("bHidesAbideByShowAvatar")]
		public bool bool_112;

		// Token: 0x040001D3 RID: 467
		[JsonProperty("bBlockAllAvatars")]
		public bool bool_113 = false;
	}
}
